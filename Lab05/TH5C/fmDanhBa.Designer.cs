#nullable enable
namespace TH5C;

partial class fmDanhBa
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
        trvDanhBa = new TreeView();
        grpNhap = new GroupBox();
        lblFirstName = new Label();
        txtFirstName = new TextBox();
        lblLastName = new Label();
        txtLastName = new TextBox();
        btnAdd = new Button();
        lblGoiY = new Label();
        btnExit = new Button();
        grpNhap.SuspendLayout();
        SuspendLayout();
        // trvDanhBa
        trvDanhBa.Name = "trvDanhBa";
        trvDanhBa.Location = new Point(20, 20);
        trvDanhBa.Size = new Size(250, 390);
        trvDanhBa.TabIndex = 0;
        trvDanhBa.HideSelection = false;
        // grpNhap
        grpNhap.Name = "grpNhap";
        grpNhap.Location = new Point(295, 20);
        grpNhap.Size = new Size(365, 230);
        grpNhap.TabIndex = 1;
        grpNhap.Text = "Nhập danh bạ";
        // lblFirstName
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Location = new Point(20, 40);
        lblFirstName.Size = new Size(100, 28);
        lblFirstName.TabIndex = 2;
        lblFirstName.Text = "First Name";
        lblFirstName.AutoSize = false;
        lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
        // txtFirstName
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Location = new Point(130, 36);
        txtFirstName.Size = new Size(210, 28);
        txtFirstName.TabIndex = 3;
        // lblLastName
        lblLastName.Name = "lblLastName";
        lblLastName.Location = new Point(20, 95);
        lblLastName.Size = new Size(100, 28);
        lblLastName.TabIndex = 4;
        lblLastName.Text = "Last Name";
        lblLastName.AutoSize = false;
        lblLastName.TextAlign = ContentAlignment.MiddleLeft;
        // txtLastName
        txtLastName.Name = "txtLastName";
        txtLastName.Location = new Point(130, 91);
        txtLastName.Size = new Size(210, 28);
        txtLastName.TabIndex = 5;
        // btnAdd
        btnAdd.Name = "btnAdd";
        btnAdd.Location = new Point(130, 150);
        btnAdd.Size = new Size(210, 38);
        btnAdd.TabIndex = 6;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        // lblGoiY
        lblGoiY.Name = "lblGoiY";
        lblGoiY.Location = new Point(295, 280);
        lblGoiY.Size = new Size(365, 65);
        lblGoiY.TabIndex = 7;
        lblGoiY.Text = "First Name: tên (Bình).\nLast Name: họ và tên đệm (Ngô Thanh).";
        lblGoiY.AutoSize = false;
        lblGoiY.TextAlign = ContentAlignment.MiddleLeft;
        // btnExit
        btnExit.Name = "btnExit";
        btnExit.Location = new Point(540, 370);
        btnExit.Size = new Size(120, 38);
        btnExit.TabIndex = 8;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        Controls.Add(btnExit);
        Controls.Add(lblGoiY);
        grpNhap.Controls.Add(btnAdd);
        grpNhap.Controls.Add(txtLastName);
        grpNhap.Controls.Add(lblLastName);
        grpNhap.Controls.Add(txtFirstName);
        grpNhap.Controls.Add(lblFirstName);
        Controls.Add(grpNhap);
        Controls.Add(trvDanhBa);
        ClientSize = new Size(680, 430);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmDanhBa";
        Text = "Về nhà 3 - Danh bạ A-Z";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        grpNhap.ResumeLayout(false);
        grpNhap.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private TreeView trvDanhBa = null!;
    private GroupBox grpNhap = null!;
    private Label lblFirstName = null!;
    private TextBox txtFirstName = null!;
    private Label lblLastName = null!;
    private TextBox txtLastName = null!;
    private Button btnAdd = null!;
    private Label lblGoiY = null!;
    private Button btnExit = null!;
}
