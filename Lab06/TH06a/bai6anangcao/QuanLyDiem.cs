using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;

namespace bai6anangcao
{
    public partial class QuanLyDiem : Form
    {
        private readonly string chuoiKetNoi = KetNoiCSDL.ChuoiKetNoi;

        public QuanLyDiem()
        {
            InitializeComponent();
        }

        private bool DocDiem(out decimal diem)
        {
            // Chấp nhận cả 8,5 và 8.5; không hiểu dấu phẩy là phân cách hàng nghìn.
            string noiDung = txtDiem.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(noiDung,
                NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out diem))
            {
                MessageBox.Show("Điểm phải là một số, ví dụ 8,5 hoặc 8.5.");
                txtDiem.Focus();
                return false;
            }
            // Khớp với cột DECIMAL(5,2), tránh database tự làm tròn điểm.
            if (diem < -999.99m || diem > 999.99m || decimal.Round(diem, 2) != diem)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng -999,99 đến 999,99 và có tối đa 2 chữ số thập phân.");
                txtDiem.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text.Trim();
            string maMonHoc = txtMaMonHoc.Text.Trim();
            if (maSinhVien == "" || maMonHoc == "" || txtDiem.Text.Trim() == "")
            {
                MessageBox.Show("Phải nhập đủ mã sinh viên, mã môn học và điểm.");
                return;
            }
            if (!DocDiem(out decimal diem))
                return;

            string sql = "INSERT INTO dbo.Diem (MaSinhVien, MaMonHoc, Diem) " +
                "VALUES (@MaSinhVien, @MaMonHoc, @Diem)";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 10).Value = maSinhVien;
                    cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 10).Value = maMonHoc;
                    SqlParameter pDiem = cmd.Parameters.Add("@Diem", SqlDbType.Decimal);
                    pDiem.Precision = 5;
                    pDiem.Scale = 2;
                    pDiem.Value = diem;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Đã thêm {soDong} dòng điểm.");
                }
            }
            catch (SqlException ex)
            {
                BaoLoiSql(ex);
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text.Trim();
            string maMonHoc = txtMaMonHoc.Text.Trim();
            if (maSinhVien == "" || maMonHoc == "")
            {
                MessageBox.Show("Khi xóa, phải nhập mã sinh viên và mã môn học.");
                return;
            }
            if (txtDiem.Text.Trim() != "")
            {
                MessageBox.Show("Khi xóa, hãy để trống ô điểm.");
                txtDiem.Focus();
                return;
            }

            string sql = "DELETE FROM dbo.Diem " +
                "WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 10).Value = maSinhVien;
                    cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 10).Value = maMonHoc;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();
                    MessageBox.Show(soDong > 0 ? "Xóa điểm thành công." : "Không tìm thấy điểm của sinh viên ở môn học này.");
                }
            }
            catch (SqlException ex)
            {
                BaoLoiSql(ex);
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text.Trim();
            string maMonHoc = txtMaMonHoc.Text.Trim();
            if (maSinhVien == "" || maMonHoc == "" || txtDiem.Text.Trim() == "")
            {
                MessageBox.Show("Khi sửa, phải nhập đủ mã sinh viên, mã môn học và điểm mới.");
                return;
            }
            if (!DocDiem(out decimal diem))
                return;

            string sql = "UPDATE dbo.Diem SET Diem = @Diem " +
                "WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar, 10).Value = maSinhVien;
                    cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 10).Value = maMonHoc;
                    SqlParameter pDiem = cmd.Parameters.Add("@Diem", SqlDbType.Decimal);
                    pDiem.Precision = 5;
                    pDiem.Scale = 2;
                    pDiem.Value = diem;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();
                    MessageBox.Show(soDong > 0 ? "Sửa điểm thành công." : "Không tìm thấy điểm của sinh viên ở môn học này.");
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
                MessageBox.Show("Sinh viên đã có điểm ở môn học này. Dùng nút Sửa để đổi điểm.");
            else if (ex.Number == 547)
                MessageBox.Show("Mã sinh viên và mã môn học phải tồn tại trong bảng SinhVien và MonHoc.");
            else
                MessageBox.Show("Lỗi SQL: " + ex.Message);
        }
    }
}
