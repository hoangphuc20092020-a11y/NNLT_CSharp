using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace bai6atrenlop
{
    public partial class QuanLyMonHoc : Form
    {
        private readonly string chuoiKetNoi =
            "Data Source=tcp:127.0.0.1,14330;" +
            "Initial Catalog=QLSinhVien;" +
            "User ID=sa;" +
            "Password=HocSQL@2026!;" +
            "Encrypt=True;TrustServerCertificate=True;";
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaMonHoc.Text.Trim();
            string ten = txtTenMonHoc.Text.Trim();
            if (ma == "")
            {
                MessageBox.Show("Bạn chưa nhập mã môn học.");
                txtMaMonHoc.Focus();
                return;
            }
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên môn học.");
                txtTenMonHoc.Focus();
                return;
            }
            string sql = "Insert into MonHoc(MaMonHoc, TenMonHoc)" +
                "values(@MaMonHoc,@TenMonHoc)";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi)) //  conn là đối tượng ket nối đến cơ sở dữ liệu SQL Server
                using (SqlCommand cmd = new SqlCommand(sql, conn)) // cmd là đối tượng thực thi câu lệnh SQL
                {
                    cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 10).Value = ma;
                    cmd.Parameters.Add("@TenMonHoc", SqlDbType.NVarChar, 100).Value = ten;
                    conn.Open(); // thuc hiện kết nối đến cơ sở dữ liệu đăng nhập
                    int soDong = cmd.ExecuteNonQuery(); // thực thi câu lệnh SQL và trả về số dòng bị ảnh hưởng
                    MessageBox.Show($"Đã thêm {soDong} môn học.");


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaMonHoc.Text.Trim();
            string ten = txtTenMonHoc.Text.Trim();
            if (ma == "")
            {
                MessageBox.Show("Bạn chưa nhập mã môn học.");
                txtMaMonHoc.Focus();
                return;
            }
            if (ten != "")
            {
                MessageBox.Show("Khi xoá hãy để trống tên môn học");
                txtMaMonHoc.Focus();
                return;
            }
            string sql = "Delete from MonHoc where MaMonHoc=@MaMonHoc";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 10).Value = ma;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();   // nếu tìm thấy id để xoá thì soDong sẽ trả về 1, nếu không tìm thấy thì soDong sẽ trả về 0
                    if (soDong > 0)
                    {
                        MessageBox.Show($"Đã xóa {soDong} môn học.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy môn học để xóa.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String ma = txtMaMonHoc.Text.Trim();
            String ten = txtTenMonHoc.Text.Trim();
            if (ma == "")
            {
                MessageBox.Show("Bạn chưa nhập mã môn học.");
                txtMaMonHoc.Focus();
                return;
            }
            if(ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên môn học.");
                txtTenMonHoc.Focus();
                return;
            }
            string sql ="UPDATE MonHoc SET TenMonHoc = @TenMonHoc " + "WHERE MaMonHoc = @MaMonHoc";
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 10).Value = ma;
                    cmd.Parameters.Add("@TenMonHoc", SqlDbType.NVarChar, 100).Value = ten;
                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();
                    if (soDong > 0)
                    {
                        MessageBox.Show("Sửa môn Học thành công");
                    } else
                    {
                        MessageBox.Show("Không tìm thấy mã môn học cần sửa");
                    }
                }

            } catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
               

        }
    }
}
