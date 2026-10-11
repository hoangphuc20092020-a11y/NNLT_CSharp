using System.Numerics;

namespace TH5C;

public partial class fmListSo : LabForm
{
    public fmListSo()
    {
        InitializeComponent();
        btnNhap.Click += btnNhap_Click;
        btnTong.Click += btnTong_Click;
        btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
        btnXoaChon.Click += btnXoaChon_Click;
        btnTang.Click += (_, _) => BienDoi(n => n + 2);
        btnBinhPhuong.Click += (_, _) => BienDoi(n => n * n);
        btnChan.Click += (_, _) => ChonTheo(true);
        btnLe.Click += (_, _) => ChonTheo(false);
        btnKetThuc.Click += (_, _) => Close();
    }

    private void btnNhap_Click(object? sender, EventArgs e)
    {
        if (!BigInteger.TryParse(txtSo.Text.Trim(), out BigInteger n) || n < 0)
        { ThongBao("Nhập số tự nhiên (số nguyên không âm)."); return; }
        lstSo.Items.Add(n); txtSo.Clear(); txtSo.Focus();
    }

    private void btnTong_Click(object? sender, EventArgs e)
    {
        BigInteger tong = BigInteger.Zero;
        foreach (BigInteger n in lstSo.Items) tong += n;
        ThongBao("Tổng các phần tử: " + tong);
    }

    private void btnXoaDauCuoi_Click(object? sender, EventArgs e)
    {
        if (lstSo.Items.Count == 0) return;
        if (lstSo.Items.Count > 1) lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        lstSo.Items.RemoveAt(0);
    }

    private void btnXoaChon_Click(object? sender, EventArgs e)
    {
        foreach (int i in lstSo.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToArray())
            lstSo.Items.RemoveAt(i);
    }

    private void BienDoi(Func<BigInteger, BigInteger> bienDoi)
    {
        for (int i = 0; i < lstSo.Items.Count; i++) lstSo.Items[i] = bienDoi((BigInteger)lstSo.Items[i]);
    }

    private void ChonTheo(bool chan)
    {
        lstSo.ClearSelected();
        for (int i = 0; i < lstSo.Items.Count; i++)
            lstSo.SetSelected(i, ((BigInteger)lstSo.Items[i]).IsEven == chan);
    }
}
