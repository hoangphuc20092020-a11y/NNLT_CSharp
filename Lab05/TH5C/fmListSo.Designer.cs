#nullable enable
namespace TH5C;

partial class fmListSo
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
        lblTieuDe = new Label();
        grpSo = new GroupBox();
        txtSo = new TextBox();
        btnNhap = new Button();
        lstSo = new ListBox();
        grpXuLy = new GroupBox();
        btnTong = new Button();
        btnXoaDauCuoi = new Button();
        btnXoaChon = new Button();
        btnTang = new Button();
        btnBinhPhuong = new Button();
        btnChan = new Button();
        btnLe = new Button();
        btnKetThuc = new Button();
        grpSo.SuspendLayout();
        grpXuLy.SuspendLayout();
        SuspendLayout();
        // lblTieuDe
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Location = new Point(20, 20);
        lblTieuDe.Size = new Size(720, 40);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "LISTBOX SỐ TỰ NHIÊN";
        lblTieuDe.AutoSize = false;
        lblTieuDe.TextAlign = ContentAlignment.MiddleLeft;
        lblTieuDe.Font = new Font("Tahoma", 15F, FontStyle.Bold);
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
        // grpSo
        grpSo.Name = "grpSo";
        grpSo.Location = new Point(20, 80);
        grpSo.Size = new Size(280, 370);
        grpSo.TabIndex = 1;
        grpSo.Text = "Nhập số tự nhiên";
        // txtSo
        txtSo.Name = "txtSo";
        txtSo.Location = new Point(20, 40);
        txtSo.Size = new Size(240, 28);
        txtSo.TabIndex = 2;
        // btnNhap
        btnNhap.Name = "btnNhap";
        btnNhap.Location = new Point(20, 80);
        btnNhap.Size = new Size(240, 34);
        btnNhap.TabIndex = 3;
        btnNhap.Text = "Nhập";
        btnNhap.UseVisualStyleBackColor = true;
        // lstSo
        lstSo.Name = "lstSo";
        lstSo.Location = new Point(20, 125);
        lstSo.Size = new Size(240, 220);
        lstSo.TabIndex = 4;
        lstSo.IntegralHeight = false;
        lstSo.HorizontalScrollbar = true;
        lstSo.SelectionMode = SelectionMode.MultiExtended;
        lstSo.Sorted = false;
        // grpXuLy
        grpXuLy.Name = "grpXuLy";
        grpXuLy.Location = new Point(320, 80);
        grpXuLy.Size = new Size(420, 370);
        grpXuLy.TabIndex = 5;
        grpXuLy.Text = "Xử lý ListBox";
        // btnTong
        btnTong.Name = "btnTong";
        btnTong.Location = new Point(20, 32);
        btnTong.Size = new Size(380, 36);
        btnTong.TabIndex = 6;
        btnTong.Text = "Tổng các phần tử trong List";
        btnTong.UseVisualStyleBackColor = true;
        // btnXoaDauCuoi
        btnXoaDauCuoi.Name = "btnXoaDauCuoi";
        btnXoaDauCuoi.Location = new Point(20, 80);
        btnXoaDauCuoi.Size = new Size(380, 36);
        btnXoaDauCuoi.TabIndex = 7;
        btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
        btnXoaDauCuoi.UseVisualStyleBackColor = true;
        // btnXoaChon
        btnXoaChon.Name = "btnXoaChon";
        btnXoaChon.Location = new Point(20, 128);
        btnXoaChon.Size = new Size(380, 36);
        btnXoaChon.TabIndex = 8;
        btnXoaChon.Text = "Xóa các phần tử đang chọn";
        btnXoaChon.UseVisualStyleBackColor = true;
        // btnTang
        btnTang.Name = "btnTang";
        btnTang.Location = new Point(20, 176);
        btnTang.Size = new Size(380, 36);
        btnTang.TabIndex = 9;
        btnTang.Text = "Tăng mỗi phần tử lên 2";
        btnTang.UseVisualStyleBackColor = true;
        // btnBinhPhuong
        btnBinhPhuong.Name = "btnBinhPhuong";
        btnBinhPhuong.Location = new Point(20, 224);
        btnBinhPhuong.Size = new Size(380, 36);
        btnBinhPhuong.TabIndex = 10;
        btnBinhPhuong.Text = "Thay bằng bình phương";
        btnBinhPhuong.UseVisualStyleBackColor = true;
        // btnChan
        btnChan.Name = "btnChan";
        btnChan.Location = new Point(20, 272);
        btnChan.Size = new Size(380, 36);
        btnChan.TabIndex = 11;
        btnChan.Text = "Chọn số chẵn";
        btnChan.UseVisualStyleBackColor = true;
        // btnLe
        btnLe.Name = "btnLe";
        btnLe.Location = new Point(20, 320);
        btnLe.Size = new Size(380, 36);
        btnLe.TabIndex = 12;
        btnLe.Text = "Chọn số lẻ";
        btnLe.UseVisualStyleBackColor = true;
        // btnKetThuc
        btnKetThuc.Name = "btnKetThuc";
        btnKetThuc.Location = new Point(20, 466);
        btnKetThuc.Size = new Size(720, 34);
        btnKetThuc.TabIndex = 13;
        btnKetThuc.Text = "KẾT THÚC";
        btnKetThuc.UseVisualStyleBackColor = true;
        Controls.Add(btnKetThuc);
        grpXuLy.Controls.Add(btnLe);
        grpXuLy.Controls.Add(btnChan);
        grpXuLy.Controls.Add(btnBinhPhuong);
        grpXuLy.Controls.Add(btnTang);
        grpXuLy.Controls.Add(btnXoaChon);
        grpXuLy.Controls.Add(btnXoaDauCuoi);
        grpXuLy.Controls.Add(btnTong);
        Controls.Add(grpXuLy);
        grpSo.Controls.Add(lstSo);
        grpSo.Controls.Add(btnNhap);
        grpSo.Controls.Add(txtSo);
        Controls.Add(grpSo);
        Controls.Add(lblTieuDe);
        ClientSize = new Size(760, 520);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmListSo";
        Text = "Về nhà 2 - Xử lý ListBox số";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        grpXuLy.ResumeLayout(false);
        grpXuLy.PerformLayout();
        grpSo.ResumeLayout(false);
        grpSo.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTieuDe = null!;
    private GroupBox grpSo = null!;
    private TextBox txtSo = null!;
    private Button btnNhap = null!;
    private ListBox lstSo = null!;
    private GroupBox grpXuLy = null!;
    private Button btnTong = null!;
    private Button btnXoaDauCuoi = null!;
    private Button btnXoaChon = null!;
    private Button btnTang = null!;
    private Button btnBinhPhuong = null!;
    private Button btnChan = null!;
    private Button btnLe = null!;
    private Button btnKetThuc = null!;
}
