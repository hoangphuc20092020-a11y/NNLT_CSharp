#nullable enable
namespace bai6avenha
{
    partial class QuanLyLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

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
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            lblMaKhoa = new Label();
            lblTenLop = new Label();
            lblMaLop = new Label();
            txtMaKhoa = new TextBox();
            txtMaLop = new TextBox();
            txtTenLop = new TextBox();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.Location = new Point(345, 278);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(228, 278);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(104, 278);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new Point(104, 80);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(68, 20);
            lblMaKhoa.TabIndex = 3;
            lblMaKhoa.Text = "Mã Khoa";
            // 
            // lblTenLop
            // 
            lblTenLop.AutoSize = true;
            lblTenLop.Location = new Point(104, 188);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(58, 20);
            lblTenLop.TabIndex = 4;
            lblTenLop.Text = "Tên lớp";
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(104, 134);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(56, 20);
            lblMaLop.TabIndex = 5;
            lblMaLop.Text = "Mã lớp";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(185, 80);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.MaxLength = 10;
            txtMaKhoa.Size = new Size(125, 27);
            txtMaKhoa.TabIndex = 0;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(185, 131);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.MaxLength = 10;
            txtMaLop.Size = new Size(125, 27);
            txtMaLop.TabIndex = 1;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(185, 185);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.MaxLength = 100;
            txtTenLop.Size = new Size(125, 27);
            txtTenLop.TabIndex = 2;
            // 
            // QuanLyLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTenLop);
            Controls.Add(txtMaLop);
            Controls.Add(txtMaKhoa);
            Controls.Add(lblMaLop);
            Controls.Add(lblTenLop);
            Controls.Add(lblMaKhoa);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Name = "QuanLyLop";
            Text = "Quản lý lớp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSua = null!;
        private Button btnXoa = null!;
        private Button btnThem = null!;
        private Label lblMaKhoa = null!;
        private Label lblTenLop = null!;
        private Label lblMaLop = null!;
        private TextBox txtMaKhoa = null!;
        private TextBox txtMaLop = null!;
        private TextBox txtTenLop = null!;
    }
}