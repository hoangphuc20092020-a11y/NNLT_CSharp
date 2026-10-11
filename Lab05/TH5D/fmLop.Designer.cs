#nullable enable
namespace TH5D;

partial class fmLop
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
        lblMaLop = new Label();
        txtMaLop = new TextBox();
        lblMaKhoa = new Label();
        txtMaKhoa = new TextBox();
        lblTenLop = new Label();
        txtTenLop = new TextBox();
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
        lblMaLop.Name = "lblMaLop";
        lblMaLop.Location = new Point(20, 35);
        lblMaLop.Size = new Size(145, 28);
        lblMaLop.TabIndex = 1;
        lblMaLop.Text = "Mã lớp";
        lblMaLop.AutoSize = false;
        lblMaLop.TextAlign = ContentAlignment.MiddleLeft;
        txtMaLop.Name = "txtMaLop";
        txtMaLop.Location = new Point(180, 33);
        txtMaLop.Size = new Size(430, 28);
        txtMaLop.TabIndex = 2;
        txtMaLop.MaxLength = 20;
        lblMaKhoa.Name = "lblMaKhoa";
        lblMaKhoa.Location = new Point(20, 87);
        lblMaKhoa.Size = new Size(145, 28);
        lblMaKhoa.TabIndex = 3;
        lblMaKhoa.Text = "Mã khoa";
        lblMaKhoa.AutoSize = false;
        lblMaKhoa.TextAlign = ContentAlignment.MiddleLeft;
        txtMaKhoa.Name = "txtMaKhoa";
        txtMaKhoa.Location = new Point(180, 85);
        txtMaKhoa.Size = new Size(430, 28);
        txtMaKhoa.TabIndex = 4;
        txtMaKhoa.MaxLength = 20;
        lblTenLop.Name = "lblTenLop";
        lblTenLop.Location = new Point(20, 139);
        lblTenLop.Size = new Size(145, 28);
        lblTenLop.TabIndex = 5;
        lblTenLop.Text = "Tên lớp";
        lblTenLop.AutoSize = false;
        lblTenLop.TextAlign = ContentAlignment.MiddleLeft;
        txtTenLop.Name = "txtTenLop";
        txtTenLop.Location = new Point(180, 137);
        txtTenLop.Size = new Size(430, 28);
        txtTenLop.TabIndex = 6;
        txtTenLop.MaxLength = 100;
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
        lblHuongDan.Text = "Xóa: chỉ nhập mã lớp. Sửa: nhập ít nhất mã khoa hoặc tên lớp.";
        lblHuongDan.AutoSize = false;
        lblHuongDan.TextAlign = ContentAlignment.MiddleLeft;
        Controls.Add(lblHuongDan);
        Controls.Add(btnXoa);
        Controls.Add(btnSua);
        Controls.Add(btnThem);
        grpNhap.Controls.Add(txtTenLop);
        grpNhap.Controls.Add(lblTenLop);
        grpNhap.Controls.Add(txtMaKhoa);
        grpNhap.Controls.Add(lblMaKhoa);
        grpNhap.Controls.Add(txtMaLop);
        grpNhap.Controls.Add(lblMaLop);
        Controls.Add(grpNhap);
        ClientSize = new Size(680, 336);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmLop";
        Text = "TH5D - SQL - Quản lý lớp";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        grpNhap.ResumeLayout(false);
        grpNhap.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private GroupBox grpNhap = null!;
    private Label lblMaLop = null!;
    private TextBox txtMaLop = null!;
    private Label lblMaKhoa = null!;
    private TextBox txtMaKhoa = null!;
    private Label lblTenLop = null!;
    private TextBox txtTenLop = null!;
    private Button btnThem = null!;
    private Button btnSua = null!;
    private Button btnXoa = null!;
    private Label lblHuongDan = null!;
}
