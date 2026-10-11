#nullable enable
namespace TH5C;

partial class fmSinhVien
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
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        Font = new Font("Tahoma", 11F);
        trvLop = new TreeView();
        lblChonLop = new Label();
        cboLop = new ComboBox();
        grpSinhVien = new GroupBox();
        lblSVMaSV = new Label();
        txtMaSV = new TextBox();
        lblSVHoTen = new Label();
        txtHoTen = new TextBox();
        lblSVDiaChi = new Label();
        txtDiaChi = new TextBox();
        btnCapNhat = new Button();
        btnXoa = new Button();
        chkThemLop = new CheckBox();
        grpThongTinLop = new GroupBox();
        lblTenLop = new Label();
        txtTenLop = new TextBox();
        btnThemLop = new Button();
        grpSinhVien.SuspendLayout();
        grpThongTinLop.SuspendLayout();
        SuspendLayout();
        // trvLop
        trvLop.Name = "trvLop";
        trvLop.Location = new Point(20, 20);
        trvLop.Size = new Size(300, 465);
        trvLop.TabIndex = 0;
        trvLop.HideSelection = false;
        // lblChonLop
        lblChonLop.Name = "lblChonLop";
        lblChonLop.Location = new Point(350, 25);
        lblChonLop.Size = new Size(110, 28);
        lblChonLop.TabIndex = 1;
        lblChonLop.Text = "Chọn lớp";
        lblChonLop.AutoSize = false;
        lblChonLop.TextAlign = ContentAlignment.MiddleLeft;
        // cboLop
        cboLop.Name = "cboLop";
        cboLop.Location = new Point(470, 22);
        cboLop.Size = new Size(400, 28);
        cboLop.TabIndex = 2;
        cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
        // grpSinhVien
        grpSinhVien.Name = "grpSinhVien";
        grpSinhVien.Location = new Point(340, 75);
        grpSinhVien.Size = new Size(540, 275);
        grpSinhVien.TabIndex = 3;
        grpSinhVien.Text = "Thông tin sinh viên";
        // lblSVMaSV
        lblSVMaSV.Name = "lblSVMaSV";
        lblSVMaSV.Location = new Point(20, 40);
        lblSVMaSV.Size = new Size(110, 28);
        lblSVMaSV.TabIndex = 4;
        lblSVMaSV.Text = "Mã SV";
        lblSVMaSV.AutoSize = false;
        lblSVMaSV.TextAlign = ContentAlignment.MiddleLeft;
        // txtMaSV
        txtMaSV.Name = "txtMaSV";
        txtMaSV.Location = new Point(140, 36);
        txtMaSV.Size = new Size(370, 28);
        txtMaSV.TabIndex = 5;
        // lblSVHoTen
        lblSVHoTen.Name = "lblSVHoTen";
        lblSVHoTen.Location = new Point(20, 90);
        lblSVHoTen.Size = new Size(110, 28);
        lblSVHoTen.TabIndex = 6;
        lblSVHoTen.Text = "Họ tên";
        lblSVHoTen.AutoSize = false;
        lblSVHoTen.TextAlign = ContentAlignment.MiddleLeft;
        // txtHoTen
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Location = new Point(140, 86);
        txtHoTen.Size = new Size(370, 28);
        txtHoTen.TabIndex = 7;
        // lblSVDiaChi
        lblSVDiaChi.Name = "lblSVDiaChi";
        lblSVDiaChi.Location = new Point(20, 140);
        lblSVDiaChi.Size = new Size(110, 28);
        lblSVDiaChi.TabIndex = 8;
        lblSVDiaChi.Text = "Địa chỉ";
        lblSVDiaChi.AutoSize = false;
        lblSVDiaChi.TextAlign = ContentAlignment.MiddleLeft;
        // txtDiaChi
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Location = new Point(140, 136);
        txtDiaChi.Size = new Size(370, 28);
        txtDiaChi.TabIndex = 9;
        // btnCapNhat
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Location = new Point(140, 205);
        btnCapNhat.Size = new Size(150, 36);
        btnCapNhat.TabIndex = 10;
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.UseVisualStyleBackColor = true;
        // btnXoa
        btnXoa.Name = "btnXoa";
        btnXoa.Location = new Point(320, 205);
        btnXoa.Size = new Size(150, 36);
        btnXoa.TabIndex = 11;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        // chkThemLop
        chkThemLop.Name = "chkThemLop";
        chkThemLop.Location = new Point(350, 365);
        chkThemLop.Size = new Size(180, 28);
        chkThemLop.TabIndex = 12;
        chkThemLop.Text = "Thêm lớp";
        chkThemLop.Checked = false;
        // grpThongTinLop
        grpThongTinLop.Name = "grpThongTinLop";
        grpThongTinLop.Location = new Point(340, 405);
        grpThongTinLop.Size = new Size(540, 80);
        grpThongTinLop.TabIndex = 13;
        grpThongTinLop.Text = "Thông tin lớp";
        grpThongTinLop.Visible = false;
        // lblTenLop
        lblTenLop.Name = "lblTenLop";
        lblTenLop.Location = new Point(20, 35);
        lblTenLop.Size = new Size(100, 28);
        lblTenLop.TabIndex = 14;
        lblTenLop.Text = "Tên lớp";
        lblTenLop.AutoSize = false;
        lblTenLop.TextAlign = ContentAlignment.MiddleLeft;
        // txtTenLop
        txtTenLop.Name = "txtTenLop";
        txtTenLop.Location = new Point(125, 31);
        txtTenLop.Size = new Size(240, 28);
        txtTenLop.TabIndex = 15;
        // btnThemLop
        btnThemLop.Name = "btnThemLop";
        btnThemLop.Location = new Point(390, 29);
        btnThemLop.Size = new Size(125, 34);
        btnThemLop.TabIndex = 16;
        btnThemLop.Text = "Thêm lớp";
        btnThemLop.UseVisualStyleBackColor = true;
        grpThongTinLop.Controls.Add(btnThemLop);
        grpThongTinLop.Controls.Add(txtTenLop);
        grpThongTinLop.Controls.Add(lblTenLop);
        Controls.Add(grpThongTinLop);
        Controls.Add(chkThemLop);
        grpSinhVien.Controls.Add(btnXoa);
        grpSinhVien.Controls.Add(btnCapNhat);
        grpSinhVien.Controls.Add(txtDiaChi);
        grpSinhVien.Controls.Add(lblSVDiaChi);
        grpSinhVien.Controls.Add(txtHoTen);
        grpSinhVien.Controls.Add(lblSVHoTen);
        grpSinhVien.Controls.Add(txtMaSV);
        grpSinhVien.Controls.Add(lblSVMaSV);
        Controls.Add(grpSinhVien);
        Controls.Add(cboLop);
        Controls.Add(lblChonLop);
        Controls.Add(trvLop);
        ClientSize = new Size(900, 510);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmSinhVien";
        Text = "Tại lớp 2 - Quản lý sinh viên";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        grpThongTinLop.ResumeLayout(false);
        grpThongTinLop.PerformLayout();
        grpSinhVien.ResumeLayout(false);
        grpSinhVien.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private TreeView trvLop = null!;
    private Label lblChonLop = null!;
    private ComboBox cboLop = null!;
    private GroupBox grpSinhVien = null!;
    private Label lblSVMaSV = null!;
    private TextBox txtMaSV = null!;
    private Label lblSVHoTen = null!;
    private TextBox txtHoTen = null!;
    private Label lblSVDiaChi = null!;
    private TextBox txtDiaChi = null!;
    private Button btnCapNhat = null!;
    private Button btnXoa = null!;
    private CheckBox chkThemLop = null!;
    private GroupBox grpThongTinLop = null!;
    private Label lblTenLop = null!;
    private TextBox txtTenLop = null!;
    private Button btnThemLop = null!;
}
