#nullable enable
namespace bai6anangcao
{
    partial class QuanLySinhVien
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
            lblMaLop = new Label();
            txtMaLop = new TextBox();
            lblMaSinhVien = new Label();
            txtMaSinhVien = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgaySinh = new Label();
            mtbNgaySinh = new MaskedTextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(32, 47);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Text = "Mã lớp";
            txtMaLop.Location = new Point(180, 44);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(310, 27);
            txtMaLop.TabIndex = 0;
            txtMaLop.MaxLength = 10;
            lblMaSinhVien.AutoSize = true;
            lblMaSinhVien.Location = new Point(32, 99);
            lblMaSinhVien.Name = "lblMaSinhVien";
            lblMaSinhVien.Text = "Mã sinh viên";
            txtMaSinhVien.Location = new Point(180, 96);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.Size = new Size(310, 27);
            txtMaSinhVien.TabIndex = 1;
            txtMaSinhVien.MaxLength = 10;
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(32, 151);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Text = "Họ tên";
            txtHoTen.Location = new Point(180, 148);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(310, 27);
            txtHoTen.TabIndex = 2;
            txtHoTen.MaxLength = 100;
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(32, 203);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Text = "Ngày sinh";
            mtbNgaySinh.Location = new Point(180, 200);
            mtbNgaySinh.Name = "mtbNgaySinh";
            mtbNgaySinh.Size = new Size(310, 27);
            mtbNgaySinh.TabIndex = 3;
            mtbNgaySinh.Mask = "00/00/0000";
            mtbNgaySinh.TextMaskFormat = MaskFormat.IncludeLiterals;
            btnThem.Location = new Point(100, 277);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 34);
            btnThem.Text = "Thêm";
            btnThem.TabIndex = 4;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            btnXoa.Location = new Point(220, 277);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 34);
            btnXoa.Text = "Xóa";
            btnXoa.TabIndex = 5;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            btnSua.Location = new Point(340, 277);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 34);
            btnSua.Text = "Sửa";
            btnSua.TabIndex = 6;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 365);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Controls.Add(lblMaLop);
            Controls.Add(txtMaLop);
            Controls.Add(lblMaSinhVien);
            Controls.Add(txtMaSinhVien);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblNgaySinh);
            Controls.Add(mtbNgaySinh);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Name = "QuanLySinhVien";
            Text = "Quản lý sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblMaLop = null!;
        private TextBox txtMaLop = null!;
        private Label lblMaSinhVien = null!;
        private TextBox txtMaSinhVien = null!;
        private Label lblHoTen = null!;
        private TextBox txtHoTen = null!;
        private Label lblNgaySinh = null!;
        private MaskedTextBox mtbNgaySinh = null!;
        private Button btnThem = null!;
        private Button btnXoa = null!;
        private Button btnSua = null!;
    }
}
