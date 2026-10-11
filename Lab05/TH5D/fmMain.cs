namespace TH5D;
public partial class fmMain : LabForm
{
    public fmMain()
    {
        InitializeComponent();
        mnuHoSo.Click += (_, _) => MoBai(new fmHoSoSinhVien());
        mnuTaiKhoan.Click += (_, _) => MoBai(new fmTaiKhoan());
        mnuChuyenLop.Click += (_, _) => MoBai(new fmChuyenLop());
        mnuDemNguoc.Click += (_, _) => MoBai(new fmDemNguoc());
        mnuMonHoc.Click += (_, _) => MoBai(new fmMonHoc());
        mnuSinhVienSql.Click += (_, _) => MoBai(new fmSinhVienSql());
        mnuDiem.Click += (_, _) => MoBai(new fmDiem());
        mnuLop.Click += (_, _) => MoBai(new fmLop());
        mnuTH5C.Click += (_, _) => MoBai(new TH5C.fmChonBai());
        mnuThoat.Click += (_, _) => Close();
        FormClosing += XacNhanDong;
    }
    protected virtual void MoBai(Form form) { using (form) form.ShowDialog(this); }
}
