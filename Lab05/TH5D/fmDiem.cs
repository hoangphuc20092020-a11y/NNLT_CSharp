using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;
namespace TH5D;
public partial class fmDiem : SqlForm
{
    public fmDiem()
    {
        InitializeComponent();
        btnThem.Click += (_, _) => XuLy("Thêm");
        btnSua.Click += (_, _) => XuLy("Sửa");
        btnXoa.Click += (_, _) => XuLy("Xóa");
    }
    private void XuLy(string lenh)
    {
        string sv = txtMaSinhVien.Text.Trim(), mh = txtMaMonHoc.Text.Trim(), chuoi = txtDiem.Text.Trim();
        if (sv.Length == 0 || mh.Length == 0) { ThongBao("Nhập mã sinh viên và mã môn học."); return; }
        decimal diem = 0;
        if (lenh == "Xóa" && chuoi.Length > 0) { ThongBao("Khi xóa để trống điểm."); return; }
        if (lenh != "Xóa" && (!decimal.TryParse(chuoi, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
            CultureInfo.GetCultureInfo("vi-VN"), out diem) || diem < 0 || diem > 10 || decimal.Round(diem, 2) != diem))
        { ThongBao("Điểm phải từ 0 đến 10, tối đa 2 chữ số thập phân; dùng dấu phẩy."); return; }
        if (!KiemTraDoDai(("Mã sinh viên", sv, 20), ("Mã môn học", mh, 20))) return;
        string sql = lenh switch
        {
            "Thêm" => "INSERT INTO dbo.Diem(MaSinhVien,MaMonHoc,Diem) VALUES(@MaSinhVien,@MaMonHoc,@Diem)",
            "Sửa" => "UPDATE dbo.Diem SET Diem=@Diem WHERE MaSinhVien=@MaSinhVien AND MaMonHoc=@MaMonHoc",
            _ => "DELETE FROM dbo.Diem WHERE MaSinhVien=@MaSinhVien AND MaMonHoc=@MaMonHoc"
        };
        var p = new List<SqlParameter> { Chuoi("@MaSinhVien", sv), Chuoi("@MaMonHoc", mh) };
        if (lenh != "Xóa") p.Add(new SqlParameter("@Diem", SqlDbType.Decimal) { Precision = 4, Scale = 2, Value = diem });
        if (ThucHien(sql, lenh + " điểm thành công.", p.ToArray()))
        { txtMaSinhVien.Clear(); txtMaMonHoc.Clear(); txtDiem.Clear(); txtMaSinhVien.Focus(); }
    }
}
