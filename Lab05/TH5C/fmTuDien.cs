namespace TH5C;

public partial class fmTuDien : LabForm
{
    private sealed record Tu(string Anh, string Viet);
    // Dữ liệu từ điển lưu sẵn trong List theo yêu cầu của đề.
    private readonly List<Tu> tuDien = new()
    {
        new("student", "sinh viên"), new("pupil", "học sinh"), new("teacher", "giáo viên"),
        new("worker", "công nhân"), new("hat", "mũ"), new("head", "đầu"),
        new("mouse", "chuột"), new("cat", "mèo"), new("dog", "chó"),
        new("snake", "rắn"), new("frog", "ếch"), new("sheep", "cừu"),
        new("house", "nhà"), new("home", "nhà"), new("book", "sách"),
        new("school", "trường học"), new("computer", "máy tính")
    };

    public fmTuDien()
    {
        InitializeComponent();
        Load += fmTuDien_Load;
        cboAnh.TextChanged += (_, _) => DoTu(cboAnh, lstAnh);
        cboViet.TextChanged += (_, _) => DoTu(cboViet, lstViet);
        cboAnh.KeyDown += (_, e) => XuLyEnter(e, true);
        cboViet.KeyDown += (_, e) => XuLyEnter(e, false);
        btnTraAnh.Click += (_, _) => Tra(true, false);
        btnTraViet.Click += (_, _) => Tra(false, false);
        lstAnh.MouseDoubleClick += (_, e) => TraTuDoubleClick(lstAnh, e, true);
        lstViet.MouseDoubleClick += (_, e) => TraTuDoubleClick(lstViet, e, false);
        btnThoat.Click += (_, _) => Close();
    }

    private void fmTuDien_Load(object? sender, EventArgs e)
    {
        cboAnh.Items.Clear(); cboViet.Items.Clear(); lstAnh.Items.Clear(); lstViet.Items.Clear();
        string[] anh = tuDien.Select(t => t.Anh).Distinct().OrderBy(s => s).ToArray();
        string[] viet = tuDien.Select(t => t.Viet).Distinct().OrderBy(s => s).ToArray();
        cboAnh.Items.AddRange(anh); lstAnh.Items.AddRange(anh);
        cboViet.Items.AddRange(viet); lstViet.Items.AddRange(viet);
    }

    private static void DoTu(ComboBox cbo, ListBox lst)
    {
        string dau = cbo.Text.Trim();
        int i = -1;
        if (dau.Length > 0)
            for (int j = 0; j < lst.Items.Count; j++)
                if (((string)lst.Items[j]).StartsWith(dau, StringComparison.OrdinalIgnoreCase))
                { i = j; break; }
        lst.SelectedIndex = i;
        if (i >= 0) lst.TopIndex = i;
        // Không sửa Text của ComboBox ở đây để tránh làm con trỏ nhập nhảy.
    }

    private void Tra(bool anhSangViet, bool tuList)
    {
        ComboBox cbo = anhSangViet ? cboAnh : cboViet;
        ListBox lst = anhSangViet ? lstAnh : lstViet;
        TextBox ketQua = anhSangViet ? txtNghiaViet : txtNghiaAnh;
        string tu = tuList ? lst.SelectedItem as string ?? "" : cbo.Text.Trim();
        if (tu.Length == 0) { ketQua.Text = "Hãy nhập hoặc chọn từ."; return; }
        string Khoa(Tu t) => anhSangViet ? t.Anh : t.Viet;
        if (!tuList && !tuDien.Any(t => string.Equals(Khoa(t), tu, StringComparison.OrdinalIgnoreCase))
            && lst.SelectedItem is string goiY) tu = goiY;
        string[] nghia = tuDien.Where(t => string.Equals(Khoa(t), tu, StringComparison.OrdinalIgnoreCase))
            .Select(t => anhSangViet ? t.Viet : t.Anh).Distinct().ToArray();
        ketQua.Text = nghia.Length > 0 ? string.Join("; ", nghia) : "Không tìm thấy từ.";
    }

    private void XuLyEnter(KeyEventArgs e, bool anhSangViet)
    {
        if (e.KeyCode != Keys.Enter) return;
        e.SuppressKeyPress = true;
        Tra(anhSangViet, false);
    }

    private void TraTuDoubleClick(ListBox lst, MouseEventArgs e, bool anhSangViet)
    {
        int i = lst.IndexFromPoint(e.Location);
        if (i < 0) return;
        lst.SelectedIndex = i;
        Tra(anhSangViet, true);
    }
}
