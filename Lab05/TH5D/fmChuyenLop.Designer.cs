#nullable enable
namespace TH5D;

partial class fmChuyenLop
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
        grpLopA = new GroupBox();
        lstLopA = new ListBox();
        grpLopB = new GroupBox();
        lstLopB = new ListBox();
        grpLopA.SuspendLayout();
        grpLopB.SuspendLayout();
        SuspendLayout();
        grpLopA.Name = "grpLopA";
        grpLopA.Location = new Point(20, 65);
        grpLopA.Size = new Size(350, 365);
        grpLopA.TabIndex = 0;
        grpLopA.Text = "Lớp A";
        lstLopA.Name = "lstLopA";
        lstLopA.Location = new Point(15, 35);
        lstLopA.Size = new Size(320, 310);
        lstLopA.TabIndex = 1;
        lstLopA.IntegralHeight = false;
        lstLopA.HorizontalScrollbar = true;
        lstLopA.SelectionMode = SelectionMode.MultiExtended;
        grpLopB.Name = "grpLopB";
        grpLopB.Location = new Point(390, 65);
        grpLopB.Size = new Size(350, 365);
        grpLopB.TabIndex = 2;
        grpLopB.Text = "Lớp B";
        lstLopB.Name = "lstLopB";
        lstLopB.Location = new Point(15, 35);
        lstLopB.Size = new Size(320, 310);
        lstLopB.TabIndex = 3;
        lstLopB.IntegralHeight = false;
        lstLopB.HorizontalScrollbar = true;
        lstLopB.SelectionMode = SelectionMode.MultiExtended;
        grpLopB.Controls.Add(lstLopB);
        Controls.Add(grpLopB);
        grpLopA.Controls.Add(lstLopA);
        Controls.Add(grpLopA);
        menuStrip1 = new MenuStrip { Name = "menuStrip1", Font = Font };
        mnuCapNhat = new ToolStripMenuItem("Cập nhật") { Name = "mnuCapNhat" };
        mnuNhap = new ToolStripMenuItem("Nhập học viên mới") { Name = "mnuNhap" };
        mnuSangB = new ToolStripMenuItem("Chuyển sang lớp B") { Name = "mnuSangB" };
        mnuSangA = new ToolStripMenuItem("Chuyển sang lớp A") { Name = "mnuSangA" };
        mnuXoa = new ToolStripMenuItem("Xóa học viên") { Name = "mnuXoa" };
        mnuKetThuc = new ToolStripMenuItem("Kết thúc") { Name = "mnuKetThuc" };
        mnuCapNhat.DropDownItems.AddRange(new ToolStripItem[] { mnuNhap, mnuSangB, mnuSangA, mnuXoa });
        menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCapNhat, mnuKetThuc });
        MainMenuStrip = menuStrip1;
        Controls.Add(menuStrip1);
        ClientSize = new Size(760, 450);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmChuyenLop";
        Text = "TH5D - Nâng cao - Quản lý học viên";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        grpLopB.ResumeLayout(false);
        grpLopB.PerformLayout();
        grpLopA.ResumeLayout(false);
        grpLopA.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private GroupBox grpLopA = null!;
    private ListBox lstLopA = null!;
    private GroupBox grpLopB = null!;
    private ListBox lstLopB = null!;
    private MenuStrip menuStrip1 = null!;
    private ToolStripMenuItem mnuCapNhat = null!;
    private ToolStripMenuItem mnuNhap = null!;
    private ToolStripMenuItem mnuSangB = null!;
    private ToolStripMenuItem mnuSangA = null!;
    private ToolStripMenuItem mnuXoa = null!;
    private ToolStripMenuItem mnuKetThuc = null!;
}
