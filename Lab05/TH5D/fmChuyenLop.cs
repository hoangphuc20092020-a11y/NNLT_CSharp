namespace TH5D;
public partial class fmChuyenLop : LabForm
{
    public fmChuyenLop()
    {
        InitializeComponent();
        lstLopA.Items.AddRange(new object[] { "Trần Hùng", "Nguyễn Hưng", "Lâm Tú" });
        lstLopB.Items.AddRange(new object[] { "Tuấn Hưng", "Hồng Ngọc", "Anh Minh", "Bảo Lâm" });
        mnuSangA.Click += (_, _) => Chuyen(lstLopB, lstLopA);
        mnuSangB.Click += (_, _) => Chuyen(lstLopA, lstLopB);
        mnuXoa.Click += (_, _) => { XoaChon(lstLopA); XoaChon(lstLopB); };
        mnuNhap.Click += (_, _) => MoFormNhap();
        mnuKetThuc.Click += (_, _) => Close();
        FormClosing += XacNhanDong;
    }

    private void Chuyen(ListBox nguon, ListBox dich)
    {
        int[] viTri = nguon.SelectedIndices.Cast<int>().ToArray();
        if (viTri.Length == 0) { ThongBao("Hãy chọn học viên trước khi chuyển lớp."); return; }
        foreach (int i in viTri) dich.Items.Add(nguon.Items[i]);
        foreach (int i in viTri.Reverse()) nguon.Items.RemoveAt(i);
    }

    private static void XoaChon(ListBox list)
    {
        foreach (int i in list.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToArray()) list.Items.RemoveAt(i);
    }

    public void ThemHocVien(string hoTen, string lop)
    {
        if (string.IsNullOrWhiteSpace(hoTen)) throw new ArgumentException("Họ tên không được rỗng.");
        ListBox dich = lop switch { "Lớp A" => lstLopA, "Lớp B" => lstLopB, _ => throw new ArgumentException("Lớp không hợp lệ.") };
        dich.Items.Add(hoTen.Trim());
    }

    protected virtual void MoFormNhap()
    {
        using var form = new fmNhapHocVien();
        form.HocVienDaNhap += ThemHocVien;
        form.ShowDialog(this);
    }
}
