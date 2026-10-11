namespace TH5C;

public partial class fmMauPhongBan : LabForm
{
    private sealed record NhanVien(string Ma, string HoTen, string DiaChi);

    public fmMauPhongBan()
    {
        InitializeComponent();
        Load += fmMauPhongBan_Load;
        btnThemPB.Click += btnThemPB_Click;
        btnXoaPB.Click += btnXoaPB_Click;
        btnThemNV.Click += btnThemNV_Click;
        btnThoat.Click += (_, _) => Close();
        FormClosing += XacNhanDong;
    }

    private void fmMauPhongBan_Load(object? sender, EventArgs e)
    {
        trvPhongBan.Nodes.Clear();
        cboPhongBan.Items.Clear();
        foreach (string ten in new[] { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" })
        {
            trvPhongBan.Nodes.Add(ten);
            cboPhongBan.Items.Add(ten);
        }
        cboPhongBan.SelectedIndex = 0;
    }

    private void btnThemPB_Click(object? sender, EventArgs e)
    {
        string ten = txtPhongBan.Text.Trim();
        if (ten.Length == 0) { ThongBao("Nhập tên phòng ban."); return; }
        // Đề yêu cầu so sánh không phân biệt chữ hoa/thường.
        if (trvPhongBan.Nodes.Cast<TreeNode>().Any(n => string.Compare(n.Text, ten, true) == 0))
        { ThongBao("Phòng ban đã tồn tại."); return; }
        trvPhongBan.Nodes.Add(ten);
        cboPhongBan.Items.Add(ten);
        cboPhongBan.SelectedItem = ten;
        txtPhongBan.Clear();
        txtPhongBan.Focus();
    }

    private void btnXoaPB_Click(object? sender, EventArgs e)
    {
        TreeNode? node = trvPhongBan.SelectedNode;
        if (node == null || node.Parent != null)
        { ThongBao("Hãy chọn node phòng ban để xóa."); return; }
        if (!XacNhan($"Xóa phòng ban {node.Text} và các nhân viên trong phòng?")) return;
        cboPhongBan.Items.Remove(node.Text);
        node.Remove();
        cboPhongBan.SelectedIndex = cboPhongBan.Items.Count > 0 ? 0 : -1;
    }

    private void btnThemNV_Click(object? sender, EventArgs e)
    {
        string ma = txtMaSo.Text.Trim(), ten = txtHoTen.Text.Trim(), diaChi = txtDiaChi.Text.Trim();
        if (cboPhongBan.SelectedItem is not string phongBan || ma.Length == 0 || ten.Length == 0 || diaChi.Length == 0)
        { ThongBao("Chọn phòng ban và nhập đủ mã số, họ tên, địa chỉ."); return; }
        TreeNode? pb = trvPhongBan.Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Text == phongBan);
        if (pb == null) { ThongBao("Phòng ban không còn tồn tại."); return; }
        bool trung = trvPhongBan.Nodes.Cast<TreeNode>().SelectMany(n => n.Nodes.Cast<TreeNode>())
            .Any(n => n.Tag is NhanVien nv && string.Equals(nv.Ma, ma, StringComparison.OrdinalIgnoreCase));
        if (trung) { ThongBao("Mã nhân viên đã tồn tại."); return; }
        TreeNode moi = pb.Nodes.Add($"{ten} ({ma})");
        moi.Tag = new NhanVien(ma, ten, diaChi);
        pb.Expand();
        txtMaSo.Clear(); txtHoTen.Clear(); txtDiaChi.Clear();
        txtMaSo.Focus();
    }
}
