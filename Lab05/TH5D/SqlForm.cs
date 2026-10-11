using System.Data;
using System.Text.Json;
using Microsoft.Data.SqlClient;

namespace TH5D;
public class SqlForm : LabForm
{
    protected virtual int ThucThi(string sql, params SqlParameter[] thamSo)
    {
        string? chuoi = Environment.GetEnvironmentVariable("TH5D_SQL_CONNECTION");
        if (string.IsNullOrWhiteSpace(chuoi))
        {
            string file = Path.Combine(AppContext.BaseDirectory, "database.config.json");
            using var json = JsonDocument.Parse(File.ReadAllText(file));
            chuoi = json.RootElement.GetProperty("ConnectionString").GetString();
        }
        using var conn = new SqlConnection(chuoi);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddRange(thamSo);
        conn.Open();
        return cmd.ExecuteNonQuery();
    }

    protected bool ThucHien(string sql, string thongBao, params SqlParameter[] thamSo)
    {
        try
        {
            int soDong = ThucThi(sql, thamSo);
            ThongBao(soDong > 0 ? thongBao : "Không tìm thấy dữ liệu phù hợp.");
            return soDong > 0;
        }
        catch (SqlException ex)
        {
            ThongBao(ex.Number switch
            {
                2627 or 2601 => "Mã hoặc cặp mã đã tồn tại.",
                547 => "Dữ liệu vi phạm khóa ngoại hoặc ràng buộc của bảng. Kiểm tra mã tham chiếu và dữ liệu đang được sử dụng.",
                _ => "Không thực hiện được lệnh SQL: " + ex.Message
            });
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or JsonException or ArgumentException or InvalidOperationException or KeyNotFoundException)
        { ThongBao("Kiểm tra cấu hình kết nối: " + ex.Message); }
        return false;
    }

    protected static SqlParameter Chuoi(string ten, string giaTri, int kichThuoc = 20)
        => new(ten, SqlDbType.NVarChar, kichThuoc) { Value = giaTri };
    protected bool KiemTraDoDai(params (string Ten, string GiaTri, int GioiHan)[] cacTruong)
    {
        foreach (var t in cacTruong)
            if (t.GiaTri.Length > t.GioiHan) { ThongBao($"{t.Ten} không được vượt {t.GioiHan} ký tự."); return false; }
        return true;
    }
}
