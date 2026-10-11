using System.Data;
using Microsoft.Data.SqlClient;
namespace TH5D;
public partial class fmSinhVienSql : SqlForm
{
    public fmSinhVienSql()
    {
        InitializeComponent();
        btnThem.Click += (_, _) => XuLy("Thêm");
        btnSua.Click += (_, _) => XuLy("Sửa");
        btnXoa.Click += (_, _) => XuLy("Xóa");
    }
    private void XuLy(string lenh)
    {
        string ma = txtMaSinhVien.Text.Trim(), lop = txtMaLop.Text.Trim(), ten = txtHoTen.Text.Trim();
        bool coNgay = dtpNgaySinh.Checked;
        if (ma.Length == 0) { ThongBao("Mã sinh viên không được để trống."); return; }
        if (lenh == "Thêm" && (lop.Length == 0 || ten.Length == 0 || !coNgay)) { ThongBao("Nhập đủ mã lớp, mã sinh viên, họ tên và chọn ngày sinh."); return; }
        if (lenh == "Xóa" && (ten.Length == 0 || lop.Length > 0 || coNgay)) { ThongBao("Khi xóa nhập mã sinh viên và họ tên; để trống mã lớp và bỏ chọn ngày sinh."); return; }
        if (lenh == "Sửa" && lop.Length == 0 && ten.Length == 0 && !coNgay) { ThongBao("Nhập ít nhất một trường cần sửa: mã lớp, họ tên hoặc ngày sinh."); return; }
        if (!KiemTraDoDai(("Mã sinh viên", ma, 20), ("Mã lớp", lop, 20), ("Họ tên", ten, 100))) return;
        string sql = lenh switch
        {
            "Thêm" => "INSERT INTO dbo.SinhVien(MaSinhVien,HoTen,NgaySinh,MaLop) VALUES(@MaSinhVien,@HoTen,@NgaySinh,@MaLop)",
            "Xóa" => "DELETE FROM dbo.SinhVien WHERE MaSinhVien=@MaSinhVien AND HoTen=@HoTen",
            _ => "UPDATE dbo.SinhVien SET MaLop=CASE WHEN @MaLop='' THEN MaLop ELSE @MaLop END, HoTen=CASE WHEN @HoTen='' THEN HoTen ELSE @HoTen END, NgaySinh=CASE WHEN @CoNgay=1 THEN @NgaySinh ELSE NgaySinh END WHERE MaSinhVien=@MaSinhVien"
        };
        var p = new List<SqlParameter> { Chuoi("@MaSinhVien", ma), Chuoi("@HoTen", ten, 100) };
        if (lenh != "Xóa")
        {
            p.Add(Chuoi("@MaLop", lop));
            p.Add(new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = dtpNgaySinh.Value.Date });
            if (lenh == "Sửa") p.Add(new SqlParameter("@CoNgay", SqlDbType.Bit) { Value = coNgay });
        }
        if (ThucHien(sql, lenh + " sinh viên thành công.", p.ToArray()))
        { txtMaSinhVien.Clear(); txtMaLop.Clear(); txtHoTen.Clear(); dtpNgaySinh.Checked = false; txtMaSinhVien.Focus(); }
    }
}
