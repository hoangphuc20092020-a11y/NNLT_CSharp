#nullable enable
namespace TH5C;

partial class fmTuDien
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
        tabTuDien = new TabControl();
        tabAnhViet = new TabPage();
        tabVietAnh = new TabPage();
        lblTuAnh = new Label();
        lblNghiaAnh = new Label();
        cboAnh = new ComboBox();
        lstAnh = new ListBox();
        txtNghiaViet = new TextBox();
        btnTraAnh = new Button();
        lblTuViet = new Label();
        lblNghiaViet = new Label();
        cboViet = new ComboBox();
        lstViet = new ListBox();
        txtNghiaAnh = new TextBox();
        btnTraViet = new Button();
        btnThoat = new Button();
        tabTuDien.SuspendLayout();
        tabAnhViet.SuspendLayout();
        tabVietAnh.SuspendLayout();
        SuspendLayout();
        // tabTuDien
        tabTuDien.Name = "tabTuDien";
        tabTuDien.Location = new Point(20, 20);
        tabTuDien.Size = new Size(720, 400);
        tabTuDien.TabIndex = 0;
        // tabAnhViet
        tabAnhViet.Name = "tabAnhViet";
        tabAnhViet.Location = new Point(0, 0);
        tabAnhViet.Size = new Size(710, 365);
        tabAnhViet.TabIndex = 1;
        tabAnhViet.Text = "Anh - Việt";
        // tabVietAnh
        tabVietAnh.Name = "tabVietAnh";
        tabVietAnh.Location = new Point(0, 0);
        tabVietAnh.Size = new Size(710, 365);
        tabVietAnh.TabIndex = 2;
        tabVietAnh.Text = "Việt - Anh";
        // lblTuAnh
        lblTuAnh.Name = "lblTuAnh";
        lblTuAnh.Location = new Point(20, 20);
        lblTuAnh.Size = new Size(280, 28);
        lblTuAnh.TabIndex = 3;
        lblTuAnh.Text = "Tiếng Anh";
        lblTuAnh.AutoSize = false;
        lblTuAnh.TextAlign = ContentAlignment.MiddleLeft;
        // lblNghiaAnh
        lblNghiaAnh.Name = "lblNghiaAnh";
        lblNghiaAnh.Location = new Point(330, 20);
        lblNghiaAnh.Size = new Size(340, 28);
        lblNghiaAnh.TabIndex = 4;
        lblNghiaAnh.Text = "Tiếng Việt";
        lblNghiaAnh.AutoSize = false;
        lblNghiaAnh.TextAlign = ContentAlignment.MiddleLeft;
        // cboAnh
        cboAnh.Name = "cboAnh";
        cboAnh.Location = new Point(20, 55);
        cboAnh.Size = new Size(280, 28);
        cboAnh.TabIndex = 5;
        cboAnh.DropDownStyle = ComboBoxStyle.DropDown;
        cboAnh.AutoCompleteMode = AutoCompleteMode.None;
        // lstAnh
        lstAnh.Name = "lstAnh";
        lstAnh.Location = new Point(20, 100);
        lstAnh.Size = new Size(280, 200);
        lstAnh.TabIndex = 6;
        lstAnh.IntegralHeight = false;
        lstAnh.HorizontalScrollbar = true;
        // txtNghiaViet
        txtNghiaViet.Name = "txtNghiaViet";
        txtNghiaViet.Location = new Point(330, 55);
        txtNghiaViet.Size = new Size(340, 245);
        txtNghiaViet.TabIndex = 7;
        txtNghiaViet.Multiline = true;
        txtNghiaViet.ReadOnly = true;
        txtNghiaViet.ScrollBars = ScrollBars.Vertical;
        // btnTraAnh
        btnTraAnh.Name = "btnTraAnh";
        btnTraAnh.Location = new Point(20, 315);
        btnTraAnh.Size = new Size(280, 34);
        btnTraAnh.TabIndex = 8;
        btnTraAnh.Text = "Enter / Tra từ";
        btnTraAnh.UseVisualStyleBackColor = true;
        // lblTuViet
        lblTuViet.Name = "lblTuViet";
        lblTuViet.Location = new Point(20, 20);
        lblTuViet.Size = new Size(280, 28);
        lblTuViet.TabIndex = 9;
        lblTuViet.Text = "Tiếng Việt";
        lblTuViet.AutoSize = false;
        lblTuViet.TextAlign = ContentAlignment.MiddleLeft;
        // lblNghiaViet
        lblNghiaViet.Name = "lblNghiaViet";
        lblNghiaViet.Location = new Point(330, 20);
        lblNghiaViet.Size = new Size(340, 28);
        lblNghiaViet.TabIndex = 10;
        lblNghiaViet.Text = "Tiếng Anh";
        lblNghiaViet.AutoSize = false;
        lblNghiaViet.TextAlign = ContentAlignment.MiddleLeft;
        // cboViet
        cboViet.Name = "cboViet";
        cboViet.Location = new Point(20, 55);
        cboViet.Size = new Size(280, 28);
        cboViet.TabIndex = 11;
        cboViet.DropDownStyle = ComboBoxStyle.DropDown;
        cboViet.AutoCompleteMode = AutoCompleteMode.None;
        // lstViet
        lstViet.Name = "lstViet";
        lstViet.Location = new Point(20, 100);
        lstViet.Size = new Size(280, 200);
        lstViet.TabIndex = 12;
        lstViet.IntegralHeight = false;
        lstViet.HorizontalScrollbar = true;
        // txtNghiaAnh
        txtNghiaAnh.Name = "txtNghiaAnh";
        txtNghiaAnh.Location = new Point(330, 55);
        txtNghiaAnh.Size = new Size(340, 245);
        txtNghiaAnh.TabIndex = 13;
        txtNghiaAnh.Multiline = true;
        txtNghiaAnh.ReadOnly = true;
        txtNghiaAnh.ScrollBars = ScrollBars.Vertical;
        // btnTraViet
        btnTraViet.Name = "btnTraViet";
        btnTraViet.Location = new Point(20, 315);
        btnTraViet.Size = new Size(280, 34);
        btnTraViet.TabIndex = 14;
        btnTraViet.Text = "Enter / Tra từ";
        btnTraViet.UseVisualStyleBackColor = true;
        // btnThoat
        btnThoat.Name = "btnThoat";
        btnThoat.Location = new Point(620, 440);
        btnThoat.Size = new Size(120, 36);
        btnThoat.TabIndex = 15;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        Controls.Add(btnThoat);
        tabVietAnh.Controls.Add(btnTraViet);
        tabVietAnh.Controls.Add(txtNghiaAnh);
        tabVietAnh.Controls.Add(lstViet);
        tabVietAnh.Controls.Add(cboViet);
        tabVietAnh.Controls.Add(lblNghiaViet);
        tabVietAnh.Controls.Add(lblTuViet);
        tabAnhViet.Controls.Add(btnTraAnh);
        tabAnhViet.Controls.Add(txtNghiaViet);
        tabAnhViet.Controls.Add(lstAnh);
        tabAnhViet.Controls.Add(cboAnh);
        tabAnhViet.Controls.Add(lblNghiaAnh);
        tabAnhViet.Controls.Add(lblTuAnh);
        Controls.Add(tabTuDien);
        tabTuDien.Controls.Add(tabAnhViet);
        tabTuDien.Controls.Add(tabVietAnh);
        ClientSize = new Size(760, 500);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmTuDien";
        Text = "Về nhà 1 - Từ điển Anh - Việt / Việt - Anh";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        tabVietAnh.ResumeLayout(false);
        tabVietAnh.PerformLayout();
        tabAnhViet.ResumeLayout(false);
        tabAnhViet.PerformLayout();
        tabTuDien.ResumeLayout(false);
        tabTuDien.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private TabControl tabTuDien = null!;
    private TabPage tabAnhViet = null!;
    private TabPage tabVietAnh = null!;
    private Label lblTuAnh = null!;
    private Label lblNghiaAnh = null!;
    private ComboBox cboAnh = null!;
    private ListBox lstAnh = null!;
    private TextBox txtNghiaViet = null!;
    private Button btnTraAnh = null!;
    private Label lblTuViet = null!;
    private Label lblNghiaViet = null!;
    private ComboBox cboViet = null!;
    private ListBox lstViet = null!;
    private TextBox txtNghiaAnh = null!;
    private Button btnTraViet = null!;
    private Button btnThoat = null!;
}
