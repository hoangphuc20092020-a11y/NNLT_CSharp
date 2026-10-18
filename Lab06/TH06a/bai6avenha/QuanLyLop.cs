using System.Data;
using Microsoft.Data.SqlClient;

namespace bai6avenha
{
    public partial class QuanLyLop : Form
    {
        private readonly string chuoiKetNoi = "Data Source=tcp:127.0.0.1,14330;" +
            "Initial Catalog=QLSinhVien;" +
            "User ID=sa;" +
            "Password=HocSQL@2026!;" +
            "Encrypt=True;TrustServerCertificate=True;";

        public QuanLyLop()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            if (maKhoa == "" || maLop == "" || tenLop == "")
            {
                MessageBox.Show("Phải nhập đủ mã khoa, mã lớp và tên lớp.");
                return;
            }

            string sql = "INSERT INTO dbo.Lop (MaLop, TenLop, MaKhoa) " +
                "VALUES (@MaLop, @TenLop, @MaKhoa)";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10).Value = maLop;
                    cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 100).Value = tenLop;
                    cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10).Value = maKhoa;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Đã thêm {soDong} lớp.");
                }
            }
            catch (SqlException ex)
            {
                BaoLoiSql(ex);
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            if (maLop == "")
            {
                MessageBox.Show("Bạn chưa nhập mã lớp.");
                txtMaLop.Focus();
                return;
            }
            if (maKhoa != "" || tenLop != "")
            {
                MessageBox.Show("Khi xóa, chỉ nhập mã lớp; để trống mã khoa và tên lớp.");
                return;
            }

            string sql = "DELETE FROM dbo.Lop WHERE MaLop = @MaLop";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10).Value = maLop;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();
                    MessageBox.Show(soDong > 0 ? "Xóa lớp thành công." : "Không tìm thấy mã lớp cần xóa.");
                }
            }
            catch (SqlException ex)
            {
                BaoLoiSql(ex);
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            if (maLop == "")
            {
                MessageBox.Show("Bạn chưa nhập mã lớp.");
                txtMaLop.Focus();
                return;
            }
            if (maKhoa == "" && tenLop == "")
            {
                MessageBox.Show("Phải nhập ít nhất mã khoa mới hoặc tên lớp mới.");
                return;
            }

            // Ô để trống giữ nguyên giá trị trong database.
            string sql = @"UPDATE dbo.Lop
                SET TenLop = CASE WHEN @TenLop = N'' THEN TenLop ELSE @TenLop END,
                    MaKhoa = CASE WHEN @MaKhoa = '' THEN MaKhoa ELSE @MaKhoa END
                WHERE MaLop = @MaLop";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10).Value = maLop;
                    cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 100).Value = tenLop;
                    cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10).Value = maKhoa;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();
                    MessageBox.Show(soDong > 0 ? "Sửa lớp thành công." : "Không tìm thấy mã lớp cần sửa.");
                }
            }
            catch (SqlException ex)
            {
                BaoLoiSql(ex);
            }
        }

        private static void BaoLoiSql(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
                MessageBox.Show("Mã lớp đã tồn tại. Hãy nhập mã khác.");
            else if (ex.Number == 547)
                MessageBox.Show("Mã khoa phải tồn tại trong bảng Khoa. Không thể xóa lớp đang có sinh viên tham chiếu.");
            else
                MessageBox.Show("Lỗi SQL: " + ex.Message);
        }
    }
}
