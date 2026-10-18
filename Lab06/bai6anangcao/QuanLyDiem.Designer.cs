#nullable enable
namespace bai6anangcao
{
    partial class QuanLyDiem
    {
        private System.ComponentModel.IContainer? components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblMaSinhVien = new Label();
            txtMaSinhVien = new TextBox();
            lblMaMonHoc = new Label();
            txtMaMonHoc = new TextBox();
            lblDiem = new Label();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            lblMaSinhVien.AutoSize = true;
            lblMaSinhVien.Location = new Point(32, 47);
            lblMaSinhVien.Name = "lblMaSinhVien";
            lblMaSinhVien.Text = "Mã sinh viên";
            txtMaSinhVien.Location = new Point(180, 44);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.Size = new Size(310, 27);
            txtMaSinhVien.TabIndex = 0;
            txtMaSinhVien.MaxLength = 10;
            lblMaMonHoc.AutoSize = true;
            lblMaMonHoc.Location = new Point(32, 99);
            lblMaMonHoc.Name = "lblMaMonHoc";
            lblMaMonHoc.Text = "Mã môn học";
            txtMaMonHoc.Location = new Point(180, 96);
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(310, 27);
            txtMaMonHoc.TabIndex = 1;
            txtMaMonHoc.MaxLength = 10;
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(32, 151);
            lblDiem.Name = "lblDiem";
            lblDiem.Text = "Điểm";
            txtDiem.Location = new Point(180, 148);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(310, 27);
            txtDiem.TabIndex = 2;
            txtDiem.MaxLength = 20;
            btnThem.Location = new Point(100, 225);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 34);
            btnThem.Text = "Thêm";
            btnThem.TabIndex = 3;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            btnXoa.Location = new Point(220, 225);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 34);
            btnXoa.Text = "Xóa";
            btnXoa.TabIndex = 4;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            btnSua.Location = new Point(340, 225);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 34);
            btnSua.Text = "Sửa";
            btnSua.TabIndex = 5;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 315);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Controls.Add(lblMaSinhVien);
            Controls.Add(txtMaSinhVien);
            Controls.Add(lblMaMonHoc);
            Controls.Add(txtMaMonHoc);
            Controls.Add(lblDiem);
            Controls.Add(txtDiem);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Name = "QuanLyDiem";
            Text = "Quản lý điểm";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblMaSinhVien = null!;
        private TextBox txtMaSinhVien = null!;
        private Label lblMaMonHoc = null!;
        private TextBox txtMaMonHoc = null!;
        private Label lblDiem = null!;
        private TextBox txtDiem = null!;
        private Button btnThem = null!;
        private Button btnXoa = null!;
        private Button btnSua = null!;
    }
}
