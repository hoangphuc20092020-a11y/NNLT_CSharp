using System;
using System.Data;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace bai6amau
{
    public partial class QuanLyKhoa : Form
    {
        private readonly string chuoiKetNoi =
            "Data Source=tcp:127.0.0.1,14330;" +
            "Initial Catalog=QLSinhVien;" +
            "User ID=sa;Password=\"HocSQL@2026!\";" +
            "Encrypt=True;TrustServerCertificate=True;";

       

        public QuanLyKhoa()
        {
            InitializeComponent();
            Text = "Quản lý Khoa";
        }

        // Hàm dùng chung cho cả Thêm, Xóa và Sửa.
        private void ThucThi(string sql, bool canTenKhoa)
        {
            string ma = txtMaKhoa.Text.Trim();
            string ten = txtTenKhoa.Text.Trim();

            if (ma == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khoa.");
                txtMaKhoa.Focus();
                return;
            }

            if (canTenKhoa && ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khoa.");
                txtTenKhoa.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(
                        "@MaKhoa", SqlDbType.VarChar, 10).Value = ma;

                    if (canTenKhoa)
                    {
                        cmd.Parameters.Add(
                            "@TenKhoa",
                            SqlDbType.NVarChar,
                            100).Value = ten;
                    }

                    conn.Open();

                    int soDong = cmd.ExecuteNonQuery();

                    if (soDong > 0)
                        MessageBox.Show("Thực hiện thành công.");
                    else
                        MessageBox.Show("Không tìm thấy mã khoa.");
                }
                // using tự đóng và giải phóng kết nối.
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã khoa đã tồn tại.");
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            string sql =
                "INSERT INTO dbo.Khoa (MaKhoa, TenKhoa) " +
                "VALUES (@MaKhoa, @TenKhoa)";

            ThucThi(sql, true);
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            string sql =
                "DELETE FROM dbo.Khoa WHERE MaKhoa = @MaKhoa";

            ThucThi(sql, false);
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            string sql =
                "UPDATE dbo.Khoa SET TenKhoa = @TenKhoa " +
                "WHERE MaKhoa = @MaKhoa";

            ThucThi(sql, true);
        }


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            lblMaKhoa = new Label();
            lblTenKhoa = new Label();
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(74, 258);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
         
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(174, 258);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            
            // 
            // btnSua
            // 
            btnSua.Location = new Point(274, 258);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new Point(53, 57);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(68, 20);
            lblMaKhoa.TabIndex = 3;
            lblMaKhoa.Text = "Mã Khoa";
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Location = new Point(53, 113);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new Size(70, 20);
            lblTenKhoa.TabIndex = 4;
            lblTenKhoa.Text = "Tên Khoa";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(159, 57);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(156, 27);
            txtMaKhoa.TabIndex = 5;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(159, 113);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(156, 27);
            txtTenKhoa.TabIndex = 6;
            // 
            // QuanLyKhoa
            // 
            ClientSize = new Size(537, 422);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(lblTenKhoa);
            Controls.Add(lblMaKhoa);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "QuanLyKhoa";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnThem = null!;
        private Button btnXoa = null!;
        private Button btnSua = null!;
        private Label lblMaKhoa = null!;
        private Label lblTenKhoa = null!;
        private TextBox txtMaKhoa = null!;
        private TextBox txtTenKhoa = null!;

    }
}