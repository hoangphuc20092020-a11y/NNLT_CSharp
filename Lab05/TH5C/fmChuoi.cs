using System.Globalization;

namespace TH5C;

public partial class fmChuoi : LabForm
{
    private readonly Random random = new();
    private readonly CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");
    private readonly string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
    private readonly string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
    private readonly string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };

    public fmChuoi()
    {
        InitializeComponent();
        btnNgauNhien.Click += btnNgauNhien_Click;
        btnXoaChon.Click += btnXoaChon_Click;
        btnXoaSon.Click += (_, _) => XoaTheo(s => string.Equals(TachTu(s).LastOrDefault(), "Sơn", StringComparison.OrdinalIgnoreCase));
        btnXoaLe.Click += (_, _) => XoaTheo(s => string.Equals(TachTu(s).FirstOrDefault(), "Lê", StringComparison.OrdinalIgnoreCase));
        btnHoa.Click += (_, _) => DoiTenChon(s => s.ToUpper(vi));
        btnThuong.Click += (_, _) => DoiTenChon(s => s.ToLower(vi));
        btnHoaDau.Click += (_, _) => DoiTenChon(s => vi.TextInfo.ToTitleCase(s.ToLower(vi)));
        btnXoaTatCa.Click += (_, _) => lstTen.Items.Clear();
        lstTen.MouseDoubleClick += lstTen_MouseDoubleClick;
    }

    private void btnNgauNhien_Click(object? sender, EventArgs e)
    {
        for (int i = 0; i < 50; i++)
            lstTen.Items.Add($"{HO[random.Next(HO.Length)]} {TENLOT[random.Next(TENLOT.Length)]} {TEN[random.Next(TEN.Length)]}");
    }

    private void btnXoaChon_Click(object? sender, EventArgs e)
    {
        foreach (int i in lstTen.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToArray())
            lstTen.Items.RemoveAt(i);
    }

    private static string[] TachTu(string s) => s.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);

    private void XoaTheo(Func<string, bool> dieuKien)
    {
        for (int i = lstTen.Items.Count - 1; i >= 0; i--)
            if (dieuKien((string)lstTen.Items[i])) lstTen.Items.RemoveAt(i);
    }

    private void DoiTenChon(Func<string, string> bienDoi)
    {
        int[] chiSo = lstTen.SelectedIndices.Cast<int>().ToArray();
        foreach (int i in chiSo) lstTen.Items[i] = bienDoi((string)lstTen.Items[i]);
        foreach (int i in chiSo) lstTen.SetSelected(i, true);
    }

    private void SuaTen(int i)
    {
        if (i < 0 || i >= lstTen.Items.Count) return;
        string moi = NhapChuoi("Nhập họ tên mới:", (string)lstTen.Items[i]).Trim();
        if (moi.Length > 0) lstTen.Items[i] = moi; // Cancel/rỗng: giữ tên cũ.
    }

    private void lstTen_MouseDoubleClick(object? sender, MouseEventArgs e)
        => SuaTen(lstTen.IndexFromPoint(e.Location));
}
