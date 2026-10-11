namespace TH5C;

public partial class fmUocSo : LabForm
{
    public fmUocSo()
    {
        InitializeComponent();
        btnCapNhat.Click += btnCapNhat_Click;
        cboSo.SelectedIndexChanged += cboSo_SelectedIndexChanged;
        btnTong.Click += btnTong_Click;
        btnDemChan.Click += btnDemChan_Click;
        btnDemNguyenTo.Click += btnDemNguyenTo_Click;
        btnThoat.Click += (_, _) => Close();
        FormClosing += XacNhanDong;
    }

    private void btnCapNhat_Click(object? sender, EventArgs e)
    {
        if (!int.TryParse(txtSo.Text.Trim(), out int n) || n <= 0)
        { ThongBao("Nhập số nguyên dương trong phạm vi Int32."); txtSo.Focus(); txtSo.SelectAll(); return; }
        if (cboSo.Items.Contains(n)) { ThongBao("Số này đã tồn tại."); return; }
        cboSo.Items.Add(n); // Lưu int để phép tính không phải phân tích chuỗi lại.
        cboSo.SelectedItem = n;
        txtSo.Clear(); txtSo.Focus();
    }

    public static int[] TimUoc(int n)
    {
        if (n <= 0) throw new ArgumentOutOfRangeException(nameof(n));
        var ketQua = new List<int>();
        // i <= n/i tương đương i*i <= n, nhưng không gây tràn số.
        for (int i = 1; i <= n / i; i++)
        {
            if (n % i != 0) continue;
            ketQua.Add(i);
            if (i != n / i) ketQua.Add(n / i);
        }
        ketQua.Sort();
        return ketQua.ToArray();
    }

    public static bool LaNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= n / i; i++) if (n % i == 0) return false;
        return true;
    }

    private void cboSo_SelectedIndexChanged(object? sender, EventArgs e)
    {
        lstUocSo.Items.Clear();
        if (cboSo.SelectedItem is int n)
            foreach (int uoc in TimUoc(n)) lstUocSo.Items.Add(uoc);
    }

    private bool CoUoc()
    {
        if (lstUocSo.Items.Count > 0) return true;
        ThongBao("Hãy chọn một số trước khi tính."); return false;
    }

    private void btnTong_Click(object? sender, EventArgs e)
    {
        if (CoUoc()) ThongBao("Tổng các ước số: " + lstUocSo.Items.Cast<int>().Sum(n => (long)n));
    }
    private void btnDemChan_Click(object? sender, EventArgs e)
    {
        if (CoUoc()) ThongBao("Số lượng ước số chẵn: " + lstUocSo.Items.Cast<int>().Count(n => n % 2 == 0));
    }
    private void btnDemNguyenTo_Click(object? sender, EventArgs e)
    {
        if (CoUoc()) ThongBao("Số lượng ước số nguyên tố: " + lstUocSo.Items.Cast<int>().Count(LaNguyenTo));
    }
}
