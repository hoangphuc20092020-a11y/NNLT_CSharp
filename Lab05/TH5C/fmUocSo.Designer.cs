#nullable enable
namespace TH5C;

partial class fmUocSo
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
        grpNhap = new GroupBox();
        txtSo = new TextBox();
        btnCapNhat = new Button();
        cboSo = new ComboBox();
        grpUoc = new GroupBox();
        lstUocSo = new ListBox();
        lblHuongDan = new Label();
        btnTong = new Button();
        btnDemChan = new Button();
        btnDemNguyenTo = new Button();
        btnThoat = new Button();
        grpNhap.SuspendLayout();
        grpUoc.SuspendLayout();
        SuspendLayout();
        // grpNhap
        grpNhap.Name = "grpNhap";
        grpNhap.Location = new Point(20, 20);
        grpNhap.Size = new Size(290, 160);
        grpNhap.TabIndex = 0;
        grpNhap.Text = "Nhập số";
        // txtSo
        txtSo.Name = "txtSo";
        txtSo.Location = new Point(20, 40);
        txtSo.Size = new Size(140, 28);
        txtSo.TabIndex = 1;
        // btnCapNhat
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Location = new Point(175, 36);
        btnCapNhat.Size = new Size(95, 34);
        btnCapNhat.TabIndex = 2;
        btnCapNhat.Text = "&Cập nhật";
        btnCapNhat.UseVisualStyleBackColor = true;
        // cboSo
        cboSo.Name = "cboSo";
        cboSo.Location = new Point(20, 100);
        cboSo.Size = new Size(250, 28);
        cboSo.TabIndex = 3;
        cboSo.DropDownStyle = ComboBoxStyle.DropDownList;
        // grpUoc
        grpUoc.Name = "grpUoc";
        grpUoc.Location = new Point(330, 20);
        grpUoc.Size = new Size(330, 160);
        grpUoc.TabIndex = 4;
        grpUoc.Text = "Danh sách các ước số";
        // lstUocSo
        lstUocSo.Name = "lstUocSo";
        lstUocSo.Location = new Point(20, 30);
        lstUocSo.Size = new Size(290, 110);
        lstUocSo.TabIndex = 5;
        lstUocSo.IntegralHeight = false;
        lstUocSo.HorizontalScrollbar = true;
        // lblHuongDan
        lblHuongDan.Name = "lblHuongDan";
        lblHuongDan.Location = new Point(20, 204);
        lblHuongDan.Size = new Size(275, 65);
        lblHuongDan.TabIndex = 6;
        lblHuongDan.Text = "Nhập số nguyên dương, sau đó chọn một số để xem các ước.";
        lblHuongDan.AutoSize = false;
        lblHuongDan.TextAlign = ContentAlignment.MiddleLeft;
        // btnTong
        btnTong.Name = "btnTong";
        btnTong.Location = new Point(330, 200);
        btnTong.Size = new Size(330, 36);
        btnTong.TabIndex = 7;
        btnTong.Text = "&Tổng các ước số";
        btnTong.UseVisualStyleBackColor = true;
        // btnDemChan
        btnDemChan.Name = "btnDemChan";
        btnDemChan.Location = new Point(330, 246);
        btnDemChan.Size = new Size(330, 36);
        btnDemChan.TabIndex = 8;
        btnDemChan.Text = "Số lượng ước số c&hẵn";
        btnDemChan.UseVisualStyleBackColor = true;
        // btnDemNguyenTo
        btnDemNguyenTo.Name = "btnDemNguyenTo";
        btnDemNguyenTo.Location = new Point(330, 292);
        btnDemNguyenTo.Size = new Size(330, 36);
        btnDemNguyenTo.TabIndex = 9;
        btnDemNguyenTo.Text = "Số lượng ước số &nguyên tố";
        btnDemNguyenTo.UseVisualStyleBackColor = true;
        // btnThoat
        btnThoat.Name = "btnThoat";
        btnThoat.Location = new Point(190, 292);
        btnThoat.Size = new Size(120, 36);
        btnThoat.TabIndex = 10;
        btnThoat.Text = "Th&oát";
        btnThoat.UseVisualStyleBackColor = true;
        Controls.Add(btnThoat);
        Controls.Add(btnDemNguyenTo);
        Controls.Add(btnDemChan);
        Controls.Add(btnTong);
        Controls.Add(lblHuongDan);
        grpUoc.Controls.Add(lstUocSo);
        Controls.Add(grpUoc);
        grpNhap.Controls.Add(cboSo);
        grpNhap.Controls.Add(btnCapNhat);
        grpNhap.Controls.Add(txtSo);
        Controls.Add(grpNhap);
        ClientSize = new Size(680, 370);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmUocSo";
        Text = "Tại lớp 1 - Ước số";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        grpUoc.ResumeLayout(false);
        grpUoc.PerformLayout();
        grpNhap.ResumeLayout(false);
        grpNhap.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private GroupBox grpNhap = null!;
    private TextBox txtSo = null!;
    private Button btnCapNhat = null!;
    private ComboBox cboSo = null!;
    private GroupBox grpUoc = null!;
    private ListBox lstUocSo = null!;
    private Label lblHuongDan = null!;
    private Button btnTong = null!;
    private Button btnDemChan = null!;
    private Button btnDemNguyenTo = null!;
    private Button btnThoat = null!;
}
