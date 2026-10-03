namespace TH04c
{
    partial class frmBaiTap2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTenDangNhap = new TextBox();
            txtDiaChiEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            lblTenDangNhap = new Label();
            lblDiaChiaEmail = new Label();
            lblMatKhau = new Label();
            lblXacNhanMatKhau = new Label();
            btnDangKy = new Button();
            lblDangKy = new Label();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(196, 64);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(206, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtDiaChiEmail
            // 
            txtDiaChiEmail.Location = new Point(196, 113);
            txtDiaChiEmail.Name = "txtDiaChiEmail";
            txtDiaChiEmail.Size = new Size(206, 27);
            txtDiaChiEmail.TabIndex = 1;
            txtDiaChiEmail.Leave += txtDiaChiEmail_Leave;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(196, 175);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(206, 27);
            txtMatKhau.TabIndex = 2;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(196, 235);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(206, 27);
            txtXacNhanMatKhau.TabIndex = 3;
            txtXacNhanMatKhau.KeyDown += txtXacNhanMatKhau_KeyDown;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(54, 67);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(110, 20);
            lblTenDangNhap.TabIndex = 4;
            lblTenDangNhap.Text = "Tên đăng Nhập";
            // 
            // lblDiaChiaEmail
            // 
            lblDiaChiaEmail.AutoSize = true;
            lblDiaChiaEmail.Location = new Point(54, 120);
            lblDiaChiaEmail.Name = "lblDiaChiaEmail";
            lblDiaChiaEmail.Size = new Size(96, 20);
            lblDiaChiaEmail.TabIndex = 5;
            lblDiaChiaEmail.Text = "Địa chỉ email";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(54, 175);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(72, 20);
            lblMatKhau.TabIndex = 6;
            lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Location = new Point(54, 235);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(134, 20);
            lblXacNhanMatKhau.TabIndex = 7;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // btnDangKy
            // 
            btnDangKy.ForeColor = SystemColors.Highlight;
            btnDangKy.Location = new Point(196, 287);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(206, 29);
            btnDangKy.TabIndex = 8;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // lblDangKy
            // 
            lblDangKy.AutoSize = true;
            lblDangKy.BackColor = SystemColors.ButtonFace;
            lblDangKy.ForeColor = SystemColors.Highlight;
            lblDangKy.Location = new Point(233, 22);
            lblDangKy.Name = "lblDangKy";
            lblDangKy.Size = new Size(128, 20);
            lblDangKy.TabIndex = 9;
            lblDangKy.Text = "Đăng ký tài khoản";
            // 
            // frmBaiTap2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 365);
            Controls.Add(lblDangKy);
            Controls.Add(btnDangKy);
            Controls.Add(lblXacNhanMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(lblDiaChiaEmail);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtDiaChiEmail);
            Controls.Add(txtTenDangNhap);
            Name = "frmBaiTap2";
            Text = "frmBaiTap2";
            FormClosing += frmBaiTap2_FormClosing;
            Load += frmBaiTap2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDangNhap;
        private TextBox txtDiaChiEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label lblTenDangNhap;
        private Label lblDiaChiaEmail;
        private Label lblMatKhau;
        private Label lblXacNhanMatKhau;
        private Label lblDangKy;
        private Button btnDangKy;
    }
}