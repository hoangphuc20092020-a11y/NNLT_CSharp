namespace TH5C;

public partial class fmSinhVien : LabForm
{
    private sealed record SinhVien(string Ma, string HoTen, string DiaChi);
    private TreeNode? goc;

    public fmSinhVien()
    {
        InitializeComponent();
        Load += fmSinhVien_Load;
        chkThemLop.CheckedChanged += (_, _) => grpThongTinLop.Visible = chkThemLop.Checked;
        btnThemLop.Click += btnThemLop_Click;
        btnCapNhat.Click += btnCapNhat_Click;
        btnXoa.Click += btnXoa_Click;
        trvLop.AfterSelect += trvLop_AfterSelect;
    }

    private void fmSinhVien_Load(object? sender, EventArgs e)
    {
        trvLop.Nodes.Clear(); cboLop.Items.Clear();
        goc = trvLop.Nodes.Add("Danh sách lớp");
        foreach (string ten in new[] { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" })
        {
            goc.Nodes.Add(ten); cboLop.Items.Add(ten);
        }
        cboLop.SelectedIndex = 0;
        chkThemLop.Checked = false;
        grpThongTinLop.Visible = false;
        goc.Expand();
    }

    private void btnThemLop_Click(object? sender, EventArgs e)
    {
        if (goc == null) return;
        string ten = txtTenLop.Text.Trim();
        if (ten.Length == 0) { ThongBao("Nhập tên lớp."); return; }
        if (goc.Nodes.Cast<TreeNode>().Any(n => string.Equals(n.Text, ten, StringComparison.OrdinalIgnoreCase)))
        { ThongBao("Tên lớp đã tồn tại."); return; }
        goc.Nodes.Add(ten); cboLop.Items.Add(ten); cboLop.SelectedItem = ten;
        goc.Expand(); txtTenLop.Clear(); txtTenLop.Focus();
    }

    private void btnCapNhat_Click(object? sender, EventArgs e)
    {
        if (goc == null) return;
        string ma = txtMaSV.Text.Trim(), hoTen = txtHoTen.Text.Trim(), diaChi = txtDiaChi.Text.Trim();
        if (ma.Length == 0 || hoTen.Length == 0 || diaChi.Length == 0 || cboLop.SelectedItem is not string tenLop)
        { ThongBao("Chọn lớp và nhập đủ mã sinh viên, họ tên, địa chỉ."); return; }
        bool trung = goc.Nodes.Cast<TreeNode>().SelectMany(n => n.Nodes.Cast<TreeNode>())
            .Any(n => n.Tag is SinhVien sv && string.Equals(sv.Ma, ma, StringComparison.OrdinalIgnoreCase));
        if (trung) { ThongBao("Mã sinh viên đã tồn tại trong danh sách."); return; }
        TreeNode? lop = goc.Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Text == tenLop);
        if (lop == null) return;
        TreeNode moi = lop.Nodes.Add($"{ma}, {hoTen}");
        moi.Tag = new SinhVien(ma, hoTen, diaChi);
        moi.Nodes.Add(diaChi);
        lop.Expand(); moi.Expand();
        txtMaSV.Clear(); txtHoTen.Clear(); txtDiaChi.Clear(); txtMaSV.Focus();
    }

    private void btnXoa_Click(object? sender, EventArgs e)
    {
        TreeNode? node = trvLop.SelectedNode;
        if (node?.Tag is not SinhVien) { ThongBao("Chỉ được xóa node mã sinh viên."); return; }
        if (!XacNhan("Bạn có muốn xóa sinh viên này?")) return;
        node.Remove(); txtMaSV.Clear(); txtHoTen.Clear(); txtDiaChi.Clear();
    }

    private void trvLop_AfterSelect(object? sender, TreeViewEventArgs e)
    {
        if (e.Node?.Tag is not SinhVien sv) return;
        txtMaSV.Text = sv.Ma; txtHoTen.Text = sv.HoTen; txtDiaChi.Text = sv.DiaChi;
        cboLop.SelectedItem = e.Node.Parent?.Text;
    }
}
