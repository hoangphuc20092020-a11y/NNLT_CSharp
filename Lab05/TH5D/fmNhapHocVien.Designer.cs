#nullable enable
namespace TH5D;

partial class fmNhapHocVien
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
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblLop = new Label();
        cboLop = new ComboBox();
        btnCapNhat = new Button();
        btnTroVe = new Button();
        SuspendLayout();
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Location = new Point(25, 30);
        lblHoTen.Size = new Size(135, 28);
        lblHoTen.TabIndex = 0;
        lblHoTen.Text = "Họ và tên";
        lblHoTen.AutoSize = false;
        lblHoTen.TextAlign = ContentAlignment.MiddleLeft;
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Location = new Point(175, 28);
        txtHoTen.Size = new Size(365, 28);
        txtHoTen.TabIndex = 1;
        txtHoTen.MaxLength = 100;
        lblLop.Name = "lblLop";
        lblLop.Location = new Point(25, 85);
        lblLop.Size = new Size(135, 28);
        lblLop.TabIndex = 2;
        lblLop.Text = "Lớp";
        lblLop.AutoSize = false;
        lblLop.TextAlign = ContentAlignment.MiddleLeft;
        cboLop.Name = "cboLop";
        cboLop.Location = new Point(175, 83);
        cboLop.Size = new Size(365, 28);
        cboLop.TabIndex = 3;
        cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Location = new Point(175, 145);
        btnCapNhat.Size = new Size(170, 36);
        btnCapNhat.TabIndex = 4;
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.UseVisualStyleBackColor = true;
        btnTroVe.Name = "btnTroVe";
        btnTroVe.Location = new Point(365, 145);
        btnTroVe.Size = new Size(175, 36);
        btnTroVe.TabIndex = 5;
        btnTroVe.Text = "Trở về";
        btnTroVe.UseVisualStyleBackColor = true;
        Controls.Add(btnTroVe);
        Controls.Add(btnCapNhat);
        Controls.Add(cboLop);
        Controls.Add(lblLop);
        Controls.Add(txtHoTen);
        Controls.Add(lblHoTen);
        ClientSize = new Size(570, 240);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmNhapHocVien";
        Text = "TH5D - Nhập học viên mới";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblHoTen = null!;
    private TextBox txtHoTen = null!;
    private Label lblLop = null!;
    private ComboBox cboLop = null!;
    private Button btnCapNhat = null!;
    private Button btnTroVe = null!;
}
