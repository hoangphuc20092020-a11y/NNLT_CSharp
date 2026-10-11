namespace TH5D;
public partial class fmMonHoc : SqlForm
{
    public fmMonHoc()
    {
        InitializeComponent();
        btnThem.Click += (_, _) => XuLy("Thêm");
        btnSua.Click += (_, _) => XuLy("Sửa");
        btnXoa.Click += (_, _) => XuLy("Xóa");
    }
    private void XuLy(string lenh)
    {
        string ma = txtMaMonHoc.Text.Trim(), ten = txtTenMonHoc.Text.Trim();
        if (ma.Length == 0 || (lenh != "Xóa" && ten.Length == 0)) { ThongBao("Nhập mã môn học và tên môn học cho thao tác thêm/sửa."); return; }
        if (lenh == "Xóa" && ten.Length > 0) { ThongBao("Khi xóa chỉ nhập mã môn học, để trống tên."); return; }
        if (!KiemTraDoDai(("Mã môn học", ma, 20), ("Tên môn học", ten, 100))) return;
        string sql = lenh switch
        {
            "Thêm" => "INSERT INTO dbo.MonHoc(MaMonHoc,TenMonHoc) VALUES(@MaMonHoc,@TenMonHoc)",
            "Sửa" => "UPDATE dbo.MonHoc SET TenMonHoc=@TenMonHoc WHERE MaMonHoc=@MaMonHoc",
            _ => "DELETE FROM dbo.MonHoc WHERE MaMonHoc=@MaMonHoc"
        };
        var p = lenh == "Xóa" ? new[] { Chuoi("@MaMonHoc", ma) } : new[] { Chuoi("@MaMonHoc", ma), Chuoi("@TenMonHoc", ten, 100) };
        if (ThucHien(sql, lenh + " môn học thành công.", p)) { txtMaMonHoc.Clear(); txtTenMonHoc.Clear(); txtMaMonHoc.Focus(); }
    }
}
