namespace TH5C;

public partial class fmChonBai : Form
{
    public fmChonBai()
    {
        InitializeComponent();
        btnMau1.Click += (_, _) => MoBai(new fmMauListBox());
        btnMau2.Click += (_, _) => MoBai(new fmMauDantoc());
        btnMau3.Click += (_, _) => MoBai(new fmMauPhongBan());
        btnLop1.Click += (_, _) => MoBai(new fmUocSo());
        btnLop2.Click += (_, _) => MoBai(new fmSinhVien());
        btnNangCao.Click += (_, _) => MoBai(new fmChuoi());
        btnNha1.Click += (_, _) => MoBai(new fmTuDien());
        btnNha2.Click += (_, _) => MoBai(new fmListSo());
        btnNha3.Click += (_, _) => MoBai(new fmDanhBa());
        btnThoat.Click += (_, _) => Close();
    }

    private void MoBai(Form form)
    {
        using (form) form.ShowDialog(this);
    }
}
