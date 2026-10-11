#nullable enable
namespace TH5D;

partial class fmDemNguoc
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
        lblPhut = new Label();
        nudPhut = new NumericUpDown();
        lblDongHo = new Label();
        btnBatDau = new Button();
        btnDung = new Button();
        SuspendLayout();
        lblPhut.Name = "lblPhut";
        lblPhut.Location = new Point(25, 25);
        lblPhut.Size = new Size(220, 28);
        lblPhut.TabIndex = 0;
        lblPhut.Text = "Thời lượng phút";
        lblPhut.AutoSize = false;
        lblPhut.TextAlign = ContentAlignment.MiddleLeft;
        nudPhut.Name = "nudPhut";
        nudPhut.Location = new Point(270, 25);
        nudPhut.Size = new Size(175, 30);
        nudPhut.TabIndex = 1;
        nudPhut.Minimum = 1;
        nudPhut.Maximum = 180;
        nudPhut.Value = 30;
        lblDongHo.Name = "lblDongHo";
        lblDongHo.Location = new Point(25, 90);
        lblDongHo.Size = new Size(420, 65);
        lblDongHo.TabIndex = 2;
        lblDongHo.Text = "30:00";
        lblDongHo.AutoSize = false;
        lblDongHo.TextAlign = ContentAlignment.MiddleLeft;
        lblDongHo.Font = new Font("Tahoma", 28F, FontStyle.Bold);
        lblDongHo.TextAlign = ContentAlignment.MiddleCenter;
        btnBatDau.Name = "btnBatDau";
        btnBatDau.Location = new Point(25, 205);
        btnBatDau.Size = new Size(200, 42);
        btnBatDau.TabIndex = 3;
        btnBatDau.Text = "Bắt đầu";
        btnBatDau.UseVisualStyleBackColor = true;
        btnDung.Name = "btnDung";
        btnDung.Location = new Point(245, 205);
        btnDung.Size = new Size(200, 42);
        btnDung.TabIndex = 4;
        btnDung.Text = "Dừng";
        btnDung.UseVisualStyleBackColor = true;
        timer1 = new System.Windows.Forms.Timer(components);
        timer1.Interval = 250;
        Controls.Add(btnDung);
        Controls.Add(btnBatDau);
        Controls.Add(lblDongHo);
        Controls.Add(nudPhut);
        Controls.Add(lblPhut);
        ClientSize = new Size(480, 290);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmDemNguoc";
        Text = "TH5D - Về nhà 1 - Đếm ngược";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblPhut = null!;
    private NumericUpDown nudPhut = null!;
    private Label lblDongHo = null!;
    private Button btnBatDau = null!;
    private Button btnDung = null!;
    private System.Windows.Forms.Timer timer1 = null!;
}
