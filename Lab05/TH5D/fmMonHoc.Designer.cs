#nullable enable
namespace TH5D;

partial class fmMonHoc
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
        lblMaMonHoc = new Label();
        txtMaMonHoc = new TextBox();
        lblTenMonHoc = new Label();
        txtTenMonHoc = new TextBox();
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        lblHuongDan = new Label();
        grpNhap.SuspendLayout();
        SuspendLayout();
        grpNhap.Name = "grpNhap";
        grpNhap.Location = new Point(20, 15);
        grpNhap.Size = new Size(640, 149);
        grpNhap.TabIndex = 0;
        grpNhap.Text = "Thông tin";
        lblMaMonHoc.Name = "lblMaMonHoc";
        lblMaMonHoc.Location = new Point(20, 35);
        lblMaMonHoc.Size = new Size(145, 28);
        lblMaMonHoc.TabIndex = 1;
        lblMaMonHoc.Text = "Mã môn học";
        lblMaMonHoc.AutoSize = false;
        lblMaMonHoc.TextAlign = ContentAlignment.MiddleLeft;
        txtMaMonHoc.Name = "txtMaMonHoc";
        txtMaMonHoc.Location = new Point(180, 33);
        txtMaMonHoc.Size = new Size(430, 28);
        txtMaMonHoc.TabIndex = 2;
        txtMaMonHoc.MaxLength = 20;
        lblTenMonHoc.Name = "lblTenMonHoc";
        lblTenMonHoc.Location = new Point(20, 87);
        lblTenMonHoc.Size = new Size(145, 28);
        lblTenMonHoc.TabIndex = 3;
        lblTenMonHoc.Text = "Tên môn học";
        lblTenMonHoc.AutoSize = false;
        lblTenMonHoc.TextAlign = ContentAlignment.MiddleLeft;
        txtTenMonHoc.Name = "txtTenMonHoc";
        txtTenMonHoc.Location = new Point(180, 85);
        txtTenMonHoc.Size = new Size(430, 28);
        txtTenMonHoc.TabIndex = 4;
        txtTenMonHoc.MaxLength = 100;
        btnThem.Name = "btnThem";
        btnThem.Location = new Point(165, 184);
        btnThem.Size = new Size(140, 36);
        btnThem.TabIndex = 5;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnSua.Name = "btnSua";
        btnSua.Location = new Point(320, 184);
        btnSua.Size = new Size(140, 36);
        btnSua.TabIndex = 6;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnXoa.Name = "btnXoa";
        btnXoa.Location = new Point(475, 184);
        btnXoa.Size = new Size(140, 36);
        btnXoa.TabIndex = 7;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        lblHuongDan.Name = "lblHuongDan";
        lblHuongDan.Location = new Point(25, 232);
        lblHuongDan.Size = new Size(630, 38);
        lblHuongDan.TabIndex = 8;
        lblHuongDan.Text = "Xóa: chỉ nhập mã môn học.";
        lblHuongDan.AutoSize = false;
        lblHuongDan.TextAlign = ContentAlignment.MiddleLeft;
        Controls.Add(lblHuongDan);
        Controls.Add(btnXoa);
        Controls.Add(btnSua);
        Controls.Add(btnThem);
        grpNhap.Controls.Add(txtTenMonHoc);
        grpNhap.Controls.Add(lblTenMonHoc);
        grpNhap.Controls.Add(txtMaMonHoc);
        grpNhap.Controls.Add(lblMaMonHoc);
        Controls.Add(grpNhap);
        ClientSize = new Size(680, 284);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmMonHoc";
        Text = "TH5D - SQL - Quản lý môn học";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        grpNhap.ResumeLayout(false);
        grpNhap.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private GroupBox grpNhap = null!;
    private Label lblMaMonHoc = null!;
    private TextBox txtMaMonHoc = null!;
    private Label lblTenMonHoc = null!;
    private TextBox txtTenMonHoc = null!;
    private Button btnThem = null!;
    private Button btnSua = null!;
    private Button btnXoa = null!;
    private Label lblHuongDan = null!;
}
