using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;

namespace bai6anangcao
{
    public partial class QuanLySinhVien : Form
    {
        private readonly string chuoiKetNoi = KetNoiCSDL.ChuoiKetNoi;

        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private bool CoNhapNgaySinh()
        {
            return mtbNgaySinh.Text.Any(char.IsDigit);
        }

        private bool DocNgaySinh(out DateTime ngaySinh)
        {
            if (!mtbNgaySinh.MaskCompleted || !DateTime.TryParseExact(
                mtbNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out ngaySinh))
            {
                ngaySinh = default;
                MessageBox.Show("Ngày sinh phải là ngày hợp lệ theo dạng dd/MM/yyyy.");
                mtbNgaySinh.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string maSinhVien = txtMaSinhVien.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            if (maLop == "" || maSinhVien == "" || hoTen == "" || !CoNhapNgaySinh())
            {
                MessageBox.Show("Phải nhập đủ mã lớp, mã sinh viên, họ tên và ngày sinh.");
                return;
            }
            if (!DocNgaySinh(out DateTime ngaySinh))
                return;

            string sql = "INSERT INTO dbo.SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) " +
                "VALUES (@MaSinhVien, @HoTen, @NgaySinh, @MaLop)";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 10).Value = maSinhVien;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = hoTen;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh.Date;
                    cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10).Value = maLop;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Đã thêm {soDong} sinh viên.");
                }
            }
            catch (SqlException ex)
            {
                BaoLoiSql(ex);
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string maSinhVien = txtMaSinhVien.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            if (maSinhVien == "" || hoTen == "")
            {
                MessageBox.Show("Khi xóa, phải nhập mã sinh viên và họ tên.");
                return;
            }
            if (maLop != "" || CoNhapNgaySinh())
            {
                MessageBox.Show("Khi xóa, hãy để trống mã lớp và ngày sinh.");
                return;
            }

            // Đề yêu cầu mã và họ tên đều trùng với dữ liệu cần xóa.
            string sql = "DELETE FROM dbo.SinhVien " +
                "WHERE MaSinhVien = @MaSinhVien AND HoTen = @HoTen";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 10).Value = maSinhVien;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = hoTen;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();
                    MessageBox.Show(soDong > 0 ? "Xóa sinh viên thành công." : "Không tìm thấy sinh viên khớp cả mã và họ tên.");
                }
            }
            catch (SqlException ex)
            {
                BaoLoiSql(ex);
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string maSinhVien = txtMaSinhVien.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            bool coNgaySinh = CoNhapNgaySinh();
            if (maSinhVien == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên.");
                txtMaSinhVien.Focus();
                return;
            }
            if (maLop == "" && hoTen == "" && !coNgaySinh)
            {
                MessageBox.Show("Phải nhập ít nhất mã lớp mới, họ tên mới hoặc ngày sinh mới.");
                return;
            }
            DateTime ngaySinh = default;
            if (coNgaySinh && !DocNgaySinh(out ngaySinh))
                return;

            string sql = @"UPDATE dbo.SinhVien
                SET MaLop = CASE WHEN @MaLop = '' THEN MaLop ELSE @MaLop END,
                    HoTen = CASE WHEN @HoTen = N'' THEN HoTen ELSE @HoTen END,
                    NgaySinh = COALESCE(@NgaySinh, NgaySinh)
                WHERE MaSinhVien = @MaSinhVien";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 10).Value = maSinhVien;
                    cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10).Value = maLop;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = hoTen;
                    // Không nhập ngày: truyền NULL để COALESCE giữ ngày cũ.
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value =
                        coNgaySinh ? (object)ngaySinh.Date : DBNull.Value;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();
                    MessageBox.Show(soDong > 0 ? "Sửa sinh viên thành công." : "Không tìm thấy mã sinh viên cần sửa.");
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
                MessageBox.Show("Mã sinh viên đã tồn tại. Hãy nhập mã khác.");
            else if (ex.Number == 547)
                MessageBox.Show("Mã lớp phải tồn tại trong bảng Lop. Không thể xóa sinh viên đang có dữ liệu điểm.");
            else
                MessageBox.Show("Lỗi SQL: " + ex.Message);
        }
    }
}
