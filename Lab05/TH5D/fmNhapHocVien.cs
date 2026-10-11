namespace TH5D;
public partial class fmNhapHocVien : LabForm
{
    public event Action<string, string>? HocVienDaNhap;
    public fmNhapHocVien()
    {
        InitializeComponent();
        cboLop.Items.AddRange(new object[] { "Lớp A", "Lớp B" }); cboLop.SelectedIndex = 0;
        btnCapNhat.Click += (_, _) =>
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text)) { ThongBao("Phải nhập họ tên học viên."); txtHoTen.Focus(); return; }
            if (cboLop.SelectedItem is not string lop) { ThongBao("Hãy chọn lớp."); return; }
            HocVienDaNhap?.Invoke(txtHoTen.Text.Trim(), lop);
            txtHoTen.Clear(); txtHoTen.Focus();
        };
        btnTroVe.Click += (_, _) => Close();
    }
}
