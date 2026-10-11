#nullable enable
namespace TH5D;

partial class fmDiem
{
    private System.ComponentModel.IContainer? components;
    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        AutoScaleMode = AutoScaleMode.Dpi;
        Font = new Font("Tahoma", 11F);
        grpNhap = new GroupBox();
        lblMaSinhVien = new Label();
        txtMaSinhVien = new TextBox();
        lblMaMonHoc = new Label();
        txtMaMonHoc = new TextBox();
        lblDiem = new Label();
        txtDiem = new TextBox();
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        lblHuongDan = new Label();
        grpNhap.SuspendLayout();
        SuspendLayout();
        grpNhap.Name = "grpNhap";
        grpNhap.Location = new Point(20, 15);
        grpNhap.Size = new Size(640, 201);
        grpNhap.TabIndex = 0;
        grpNhap.Text = "Thông tin";
        lblMaSinhVien.Name = "lblMaSinhVien";
        lblMaSinhVien.Location = new Point(20, 35);
        lblMaSinhVien.Size = new Size(145, 28);
        lblMaSinhVien.TabIndex = 1;
        lblMaSinhVien.Text = "Mã sinh viên";
        lblMaSinhVien.AutoSize = false;
        lblMaSinhVien.TextAlign = ContentAlignment.MiddleLeft;
        txtMaSinhVien.Name = "txtMaSinhVien";
        txtMaSinhVien.Location = new Point(180, 33);
        txtMaSinhVien.Size = new Size(430, 28);
        txtMaSinhVien.TabIndex = 2;
        txtMaSinhVien.MaxLength = 20;
        lblMaMonHoc.Name = "lblMaMonHoc";
        lblMaMonHoc.Location = new Point(20, 87);
        lblMaMonHoc.Size = new Size(145, 28);
        lblMaMonHoc.TabIndex = 3;
        lblMaMonHoc.Text = "Mã môn học";
        lblMaMonHoc.AutoSize = false;
        lblMaMonHoc.TextAlign = ContentAlignment.MiddleLeft;
        txtMaMonHoc.Name = "txtMaMonHoc";
        txtMaMonHoc.Location = new Point(180, 85);
        txtMaMonHoc.Size = new Size(430, 28);
        txtMaMonHoc.TabIndex = 4;
        txtMaMonHoc.MaxLength = 20;
        lblDiem.Name = "lblDiem";
        lblDiem.Location = new Point(20, 139);
        lblDiem.Size = new Size(145, 28);
        lblDiem.TabIndex = 5;
        lblDiem.Text = "Điểm";
        lblDiem.AutoSize = false;
        lblDiem.TextAlign = ContentAlignment.MiddleLeft;
        txtDiem.Name = "txtDiem";
        txtDiem.Location = new Point(180, 137);
        txtDiem.Size = new Size(430, 28);
        txtDiem.TabIndex = 6;
        txtDiem.MaxLength = 20;
        btnThem.Name = "btnThem";
        btnThem.Location = new Point(165, 236);
        btnThem.Size = new Size(140, 36);
        btnThem.TabIndex = 7;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnSua.Name = "btnSua";
        btnSua.Location = new Point(320, 236);
        btnSua.Size = new Size(140, 36);
        btnSua.TabIndex = 8;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnXoa.Name = "btnXoa";
        btnXoa.Location = new Point(475, 236);
        btnXoa.Size = new Size(140, 36);
        btnXoa.TabIndex = 9;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        lblHuongDan.Name = "lblHuongDan";
        lblHuongDan.Location = new Point(25, 284);
        lblHuongDan.Size = new Size(630, 38);
        lblHuongDan.TabIndex = 10;
        lblHuongDan.Text = "Điểm từ 0 đến 10; dấu phẩy thập phân. Xóa: để trống điểm.";
        lblHuongDan.AutoSize = false;
        lblHuongDan.TextAlign = ContentAlignment.MiddleLeft;
        Controls.Add(lblHuongDan);
        Controls.Add(btnXoa);
        Controls.Add(btnSua);
        Controls.Add(btnThem);
        grpNhap.Controls.Add(txtDiem);
        grpNhap.Controls.Add(lblDiem);
        grpNhap.Controls.Add(txtMaMonHoc);
        grpNhap.Controls.Add(lblMaMonHoc);
        grpNhap.Controls.Add(txtMaSinhVien);
        grpNhap.Controls.Add(lblMaSinhVien);
        Controls.Add(grpNhap);
        ClientSize = new Size(680, 336);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmDiem";
        Text = "TH5D - SQL - Quản lý điểm";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        grpNhap.ResumeLayout(false);
        grpNhap.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private GroupBox grpNhap = null!;
    private Label lblMaSinhVien = null!;
    private TextBox txtMaSinhVien = null!;
    private Label lblMaMonHoc = null!;
    private TextBox txtMaMonHoc = null!;
    private Label lblDiem = null!;
    private TextBox txtDiem = null!;
    private Button btnThem = null!;
    private Button btnSua = null!;
    private Button btnXoa = null!;
    private Label lblHuongDan = null!;
}
