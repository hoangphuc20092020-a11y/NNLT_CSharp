#nullable enable
namespace TH5C;

partial class fmMauPhongBan
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
        lblPhongBan = new Label();
        trvPhongBan = new TreeView();
        txtPhongBan = new TextBox();
        btnThemPB = new Button();
        btnXoaPB = new Button();
        grpNhanVien = new GroupBox();
        lblNVMaSo = new Label();
        txtMaSo = new TextBox();
        lblNVHoTen = new Label();
        txtHoTen = new TextBox();
        lblNVDiaChi = new Label();
        txtDiaChi = new TextBox();
        lblNVPhongBan = new Label();
        cboPhongBan = new ComboBox();
        btnThemNV = new Button();
        btnThoat = new Button();
        grpNhanVien.SuspendLayout();
        SuspendLayout();
        // lblPhongBan
        lblPhongBan.Name = "lblPhongBan";
        lblPhongBan.Location = new Point(20, 16);
        lblPhongBan.Size = new Size(280, 28);
        lblPhongBan.TabIndex = 0;
        lblPhongBan.Text = "Phòng ban";
        lblPhongBan.AutoSize = false;
        lblPhongBan.TextAlign = ContentAlignment.MiddleLeft;
        // trvPhongBan
        trvPhongBan.Name = "trvPhongBan";
        trvPhongBan.Location = new Point(20, 50);
        trvPhongBan.Size = new Size(280, 320);
        trvPhongBan.TabIndex = 1;
        trvPhongBan.HideSelection = false;
        // txtPhongBan
        txtPhongBan.Name = "txtPhongBan";
        txtPhongBan.Location = new Point(20, 394);
        txtPhongBan.Size = new Size(280, 28);
        txtPhongBan.TabIndex = 2;
        // btnThemPB
        btnThemPB.Name = "btnThemPB";
        btnThemPB.Location = new Point(20, 432);
        btnThemPB.Size = new Size(280, 38);
        btnThemPB.TabIndex = 3;
        btnThemPB.Text = "Thêm phòng ban";
        btnThemPB.UseVisualStyleBackColor = true;
        // btnXoaPB
        btnXoaPB.Name = "btnXoaPB";
        btnXoaPB.Location = new Point(20, 480);
        btnXoaPB.Size = new Size(280, 38);
        btnXoaPB.TabIndex = 4;
        btnXoaPB.Text = "Xóa phòng ban";
        btnXoaPB.UseVisualStyleBackColor = true;
        // grpNhanVien
        grpNhanVien.Name = "grpNhanVien";
        grpNhanVien.Location = new Point(330, 20);
        grpNhanVien.Size = new Size(500, 360);
        grpNhanVien.TabIndex = 5;
        grpNhanVien.Text = "Hồ sơ nhân viên";
        // lblNVMaSo
        lblNVMaSo.Name = "lblNVMaSo";
        lblNVMaSo.Location = new Point(20, 48);
        lblNVMaSo.Size = new Size(95, 28);
        lblNVMaSo.TabIndex = 6;
        lblNVMaSo.Text = "Mã số";
        lblNVMaSo.AutoSize = false;
        lblNVMaSo.TextAlign = ContentAlignment.MiddleLeft;
        // txtMaSo
        txtMaSo.Name = "txtMaSo";
        txtMaSo.Location = new Point(120, 44);
        txtMaSo.Size = new Size(350, 28);
        txtMaSo.TabIndex = 7;
        // lblNVHoTen
        lblNVHoTen.Name = "lblNVHoTen";
        lblNVHoTen.Location = new Point(20, 98);
        lblNVHoTen.Size = new Size(95, 28);
        lblNVHoTen.TabIndex = 8;
        lblNVHoTen.Text = "Họ tên";
        lblNVHoTen.AutoSize = false;
        lblNVHoTen.TextAlign = ContentAlignment.MiddleLeft;
        // txtHoTen
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Location = new Point(120, 94);
        txtHoTen.Size = new Size(350, 28);
        txtHoTen.TabIndex = 9;
        // lblNVDiaChi
        lblNVDiaChi.Name = "lblNVDiaChi";
        lblNVDiaChi.Location = new Point(20, 148);
        lblNVDiaChi.Size = new Size(95, 28);
        lblNVDiaChi.TabIndex = 10;
        lblNVDiaChi.Text = "Địa chỉ";
        lblNVDiaChi.AutoSize = false;
        lblNVDiaChi.TextAlign = ContentAlignment.MiddleLeft;
        // txtDiaChi
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Location = new Point(120, 144);
        txtDiaChi.Size = new Size(350, 28);
        txtDiaChi.TabIndex = 11;
        // lblNVPhongBan
        lblNVPhongBan.Name = "lblNVPhongBan";
        lblNVPhongBan.Location = new Point(20, 198);
        lblNVPhongBan.Size = new Size(95, 28);
        lblNVPhongBan.TabIndex = 12;
        lblNVPhongBan.Text = "Phòng ban";
        lblNVPhongBan.AutoSize = false;
        lblNVPhongBan.TextAlign = ContentAlignment.MiddleLeft;
        // cboPhongBan
        cboPhongBan.Name = "cboPhongBan";
        cboPhongBan.Location = new Point(120, 194);
        cboPhongBan.Size = new Size(350, 28);
        cboPhongBan.TabIndex = 13;
        cboPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
        // btnThemNV
        btnThemNV.Name = "btnThemNV";
        btnThemNV.Location = new Point(120, 255);
        btnThemNV.Size = new Size(160, 36);
        btnThemNV.TabIndex = 14;
        btnThemNV.Text = "Thêm nhân viên";
        btnThemNV.UseVisualStyleBackColor = true;
        // btnThoat
        btnThoat.Name = "btnThoat";
        btnThoat.Location = new Point(300, 255);
        btnThoat.Size = new Size(120, 36);
        btnThoat.TabIndex = 15;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        grpNhanVien.Controls.Add(btnThoat);
        grpNhanVien.Controls.Add(btnThemNV);
        grpNhanVien.Controls.Add(cboPhongBan);
        grpNhanVien.Controls.Add(lblNVPhongBan);
        grpNhanVien.Controls.Add(txtDiaChi);
        grpNhanVien.Controls.Add(lblNVDiaChi);
        grpNhanVien.Controls.Add(txtHoTen);
        grpNhanVien.Controls.Add(lblNVHoTen);
        grpNhanVien.Controls.Add(txtMaSo);
        grpNhanVien.Controls.Add(lblNVMaSo);
        Controls.Add(grpNhanVien);
        Controls.Add(btnXoaPB);
        Controls.Add(btnThemPB);
        Controls.Add(txtPhongBan);
        Controls.Add(trvPhongBan);
        Controls.Add(lblPhongBan);
        ClientSize = new Size(850, 540);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmMauPhongBan";
        Text = "Mẫu 3 - Phòng ban và nhân viên";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        grpNhanVien.ResumeLayout(false);
        grpNhanVien.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblPhongBan = null!;
    private TreeView trvPhongBan = null!;
    private TextBox txtPhongBan = null!;
    private Button btnThemPB = null!;
    private Button btnXoaPB = null!;
    private GroupBox grpNhanVien = null!;
    private Label lblNVMaSo = null!;
    private TextBox txtMaSo = null!;
    private Label lblNVHoTen = null!;
    private TextBox txtHoTen = null!;
    private Label lblNVDiaChi = null!;
    private TextBox txtDiaChi = null!;
    private Label lblNVPhongBan = null!;
    private ComboBox cboPhongBan = null!;
    private Button btnThemNV = null!;
    private Button btnThoat = null!;
}
