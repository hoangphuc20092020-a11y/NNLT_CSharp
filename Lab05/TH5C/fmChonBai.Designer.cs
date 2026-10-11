#nullable enable
namespace TH5C;

partial class fmChonBai
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
        lblHuongDan = new Label();
        grpMau = new GroupBox();
        grpTaiLop = new GroupBox();
        grpVeNha = new GroupBox();
        btnMau1 = new Button();
        btnMau2 = new Button();
        btnMau3 = new Button();
        btnLop1 = new Button();
        btnLop2 = new Button();
        btnNangCao = new Button();
        btnNha1 = new Button();
        btnNha2 = new Button();
        btnNha3 = new Button();
        btnThoat = new Button();
        grpMau.SuspendLayout();
        grpTaiLop.SuspendLayout();
        grpVeNha.SuspendLayout();
        SuspendLayout();
        // lblTieuDe
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Location = new Point(20, 20);
        lblTieuDe.Size = new Size(860, 36);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "LAB 05 - WINDOWS FORMS NÂNG CAO";
        lblTieuDe.AutoSize = false;
        lblTieuDe.TextAlign = ContentAlignment.MiddleLeft;
        lblTieuDe.Font = new Font("Tahoma", 15F, FontStyle.Bold);
        lblTieuDe.ForeColor = Color.Navy;
        // lblHuongDan
        lblHuongDan.Name = "lblHuongDan";
        lblHuongDan.Location = new Point(20, 63);
        lblHuongDan.Size = new Size(860, 28);
        lblHuongDan.TabIndex = 1;
        lblHuongDan.Text = "Chọn bài thực hành. Đóng cửa sổ bài để quay lại danh sách.";
        lblHuongDan.AutoSize = false;
        lblHuongDan.TextAlign = ContentAlignment.MiddleLeft;
        // grpMau
        grpMau.Name = "grpMau";
        grpMau.Location = new Point(20, 110);
        grpMau.Size = new Size(270, 270);
        grpMau.TabIndex = 2;
        grpMau.Text = "Bài mẫu";
        // grpTaiLop
        grpTaiLop.Name = "grpTaiLop";
        grpTaiLop.Location = new Point(315, 110);
        grpTaiLop.Size = new Size(270, 270);
        grpTaiLop.TabIndex = 3;
        grpTaiLop.Text = "Tại lớp và nâng cao";
        // grpVeNha
        grpVeNha.Name = "grpVeNha";
        grpVeNha.Location = new Point(610, 110);
        grpVeNha.Size = new Size(270, 270);
        grpVeNha.TabIndex = 4;
        grpVeNha.Text = "Bài về nhà";
        // btnMau1
        btnMau1.Name = "btnMau1";
        btnMau1.Location = new Point(15, 40);
        btnMau1.Size = new Size(240, 58);
        btnMau1.TabIndex = 5;
        btnMau1.Text = "Mẫu 1 - Hai ListBox";
        btnMau1.UseVisualStyleBackColor = true;
        // btnMau2
        btnMau2.Name = "btnMau2";
        btnMau2.Location = new Point(15, 115);
        btnMau2.Size = new Size(240, 58);
        btnMau2.TabIndex = 6;
        btnMau2.Text = "Mẫu 2 - ComboBox dân tộc";
        btnMau2.UseVisualStyleBackColor = true;
        // btnMau3
        btnMau3.Name = "btnMau3";
        btnMau3.Location = new Point(15, 190);
        btnMau3.Size = new Size(240, 58);
        btnMau3.TabIndex = 7;
        btnMau3.Text = "Mẫu 3 - Phòng ban";
        btnMau3.UseVisualStyleBackColor = true;
        // btnLop1
        btnLop1.Name = "btnLop1";
        btnLop1.Location = new Point(15, 40);
        btnLop1.Size = new Size(240, 58);
        btnLop1.TabIndex = 8;
        btnLop1.Text = "Tại lớp 1 - Ước số";
        btnLop1.UseVisualStyleBackColor = true;
        // btnLop2
        btnLop2.Name = "btnLop2";
        btnLop2.Location = new Point(15, 115);
        btnLop2.Size = new Size(240, 58);
        btnLop2.TabIndex = 9;
        btnLop2.Text = "Tại lớp 2 - Sinh viên";
        btnLop2.UseVisualStyleBackColor = true;
        // btnNangCao
        btnNangCao.Name = "btnNangCao";
        btnNangCao.Location = new Point(15, 190);
        btnNangCao.Size = new Size(240, 58);
        btnNangCao.TabIndex = 10;
        btnNangCao.Text = "Nâng cao - Xử lý chuỗi";
        btnNangCao.UseVisualStyleBackColor = true;
        // btnNha1
        btnNha1.Name = "btnNha1";
        btnNha1.Location = new Point(15, 40);
        btnNha1.Size = new Size(240, 58);
        btnNha1.TabIndex = 11;
        btnNha1.Text = "Về nhà 1 - Từ điển";
        btnNha1.UseVisualStyleBackColor = true;
        // btnNha2
        btnNha2.Name = "btnNha2";
        btnNha2.Location = new Point(15, 115);
        btnNha2.Size = new Size(240, 58);
        btnNha2.TabIndex = 12;
        btnNha2.Text = "Về nhà 2 - ListBox số";
        btnNha2.UseVisualStyleBackColor = true;
        // btnNha3
        btnNha3.Name = "btnNha3";
        btnNha3.Location = new Point(15, 190);
        btnNha3.Size = new Size(240, 58);
        btnNha3.TabIndex = 13;
        btnNha3.Text = "Về nhà 3 - Danh bạ";
        btnNha3.UseVisualStyleBackColor = true;
        // btnThoat
        btnThoat.Name = "btnThoat";
        btnThoat.Location = new Point(760, 400);
        btnThoat.Size = new Size(120, 36);
        btnThoat.TabIndex = 14;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        Controls.Add(btnThoat);
        grpVeNha.Controls.Add(btnNha3);
        grpVeNha.Controls.Add(btnNha2);
        grpVeNha.Controls.Add(btnNha1);
        grpTaiLop.Controls.Add(btnNangCao);
        grpTaiLop.Controls.Add(btnLop2);
        grpTaiLop.Controls.Add(btnLop1);
        grpMau.Controls.Add(btnMau3);
        grpMau.Controls.Add(btnMau2);
        grpMau.Controls.Add(btnMau1);
        Controls.Add(grpVeNha);
        Controls.Add(grpTaiLop);
        Controls.Add(grpMau);
        Controls.Add(lblHuongDan);
        Controls.Add(lblTieuDe);
        ClientSize = new Size(900, 450);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmChonBai";
        Text = "Lab 05 - Windows Forms nâng cao";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        grpVeNha.ResumeLayout(false);
        grpVeNha.PerformLayout();
        grpTaiLop.ResumeLayout(false);
        grpTaiLop.PerformLayout();
        grpMau.ResumeLayout(false);
        grpMau.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTieuDe = null!;
    private Label lblHuongDan = null!;
    private GroupBox grpMau = null!;
    private GroupBox grpTaiLop = null!;
    private GroupBox grpVeNha = null!;
    private Button btnMau1 = null!;
    private Button btnMau2 = null!;
    private Button btnMau3 = null!;
    private Button btnLop1 = null!;
    private Button btnLop2 = null!;
    private Button btnNangCao = null!;
    private Button btnNha1 = null!;
    private Button btnNha2 = null!;
    private Button btnNha3 = null!;
    private Button btnThoat = null!;
}
