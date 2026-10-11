namespace TH5D;
public partial class fmLop : SqlForm
{
    public fmLop()
    {
        InitializeComponent();
        btnThem.Click += (_, _) => XuLy("Thêm");
        btnSua.Click += (_, _) => XuLy("Sửa");
        btnXoa.Click += (_, _) => XuLy("Xóa");
    }
    private void XuLy(string lenh)
    {
        string lop = txtMaLop.Text.Trim(), khoa = txtMaKhoa.Text.Trim(), ten = txtTenLop.Text.Trim();
        if (lop.Length == 0) { ThongBao("Mã lớp không được để trống."); return; }
        if (lenh == "Thêm" && (khoa.Length == 0 || ten.Length == 0)) { ThongBao("Nhập đủ mã khoa, mã lớp và tên lớp."); return; }
        if (lenh == "Xóa" && (khoa.Length > 0 || ten.Length > 0)) { ThongBao("Khi xóa chỉ nhập mã lớp; để trống mã khoa và tên lớp."); return; }
        if (lenh == "Sửa" && khoa.Length == 0 && ten.Length == 0) { ThongBao("Nhập ít nhất mã khoa hoặc tên lớp cần sửa."); return; }
        if (!KiemTraDoDai(("Mã lớp", lop, 20), ("Mã khoa", khoa, 20), ("Tên lớp", ten, 100))) return;
        string sql = lenh switch
        {
            "Thêm" => "INSERT INTO dbo.Lop(MaLop,TenLop,MaKhoa) VALUES(@MaLop,@TenLop,@MaKhoa)",
            "Sửa" => "UPDATE dbo.Lop SET MaKhoa=CASE WHEN @MaKhoa='' THEN MaKhoa ELSE @MaKhoa END, TenLop=CASE WHEN @TenLop='' THEN TenLop ELSE @TenLop END WHERE MaLop=@MaLop",
            _ => "DELETE FROM dbo.Lop WHERE MaLop=@MaLop"
        };
        var p = lenh == "Xóa" ? new[] { Chuoi("@MaLop", lop) } : new[] { Chuoi("@MaLop", lop), Chuoi("@MaKhoa", khoa), Chuoi("@TenLop", ten, 100) };
        if (ThucHien(sql, lenh + " lớp thành công.", p)) { txtMaKhoa.Clear(); txtMaLop.Clear(); txtTenLop.Clear(); txtMaLop.Focus(); }
    }
}
