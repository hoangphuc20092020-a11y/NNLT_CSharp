using System.Dynamic;

namespace MyLib;

public class SinhVien
{
    public string HoTen{ get; set; }
    public int NamSinh{ get; set;}
    
    public SinhVien()
    {
        HoTen ="";
        NamSinh = 0;
    }

    public SinhVien(string hoTen, int namSinh)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
    }
    
    public int TinhTuoi(int namHienTai)
    {
        return namHienTai - NamSinh;
    }
}