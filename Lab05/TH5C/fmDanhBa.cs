using System.Globalization;
using System.Text;

namespace TH5C;

public partial class fmDanhBa : LabForm
{
    public fmDanhBa()
    {
        InitializeComponent();
        Load += fmDanhBa_Load;
        btnAdd.Click += btnAdd_Click;
        btnExit.Click += (_, _) => Close();
    }

    private void fmDanhBa_Load(object? sender, EventArgs e)
    {
        trvDanhBa.Nodes.Clear();
        for (char c = 'A'; c <= 'Z'; c++) trvDanhBa.Nodes.Add(c.ToString(), c.ToString());
    }

    public static char ChuCaiDau(string ten)
    {
        // Á/Â/Ă -> A, Đ -> D để tên tiếng Việt vào đúng node A-Z.
        string s = ten.Trim().ToUpperInvariant().Replace('Đ', 'D').Normalize(NormalizationForm.FormD);
        foreach (char c in s)
            if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark) return c;
        return '\0';
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        string ten = txtFirstName.Text.Trim(), ho = txtLastName.Text.Trim();
        if (ten.Length == 0 || ho.Length == 0) { ThongBao("Nhập đủ First Name và Last Name."); return; }
        char dau = ChuCaiDau(ten);
        if (dau < 'A' || dau > 'Z') { ThongBao("Tên phải bắt đầu bằng chữ thuộc nhóm A-Z."); return; }
        TreeNode? nhom = trvDanhBa.Nodes[dau.ToString()];
        if (nhom == null) return;
        TreeNode moi = nhom.Nodes.Add($"{ten}, {ho}");
        nhom.Expand(); trvDanhBa.SelectedNode = moi; moi.EnsureVisible();
        txtFirstName.Clear(); txtLastName.Clear(); txtFirstName.Focus();
    }
}
