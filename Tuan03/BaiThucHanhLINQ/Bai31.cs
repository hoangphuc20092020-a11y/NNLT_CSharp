using System;
namespace BaiThucHanhLINQ;
public class Bai31
{
    public static void chay()
    
    {
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
        Bai31_A(mangSo);
        Bai31_B(mangSo);
        Bai31_C(mangSo);
        Bai31_D(mangSo);



    }
    public static void Bai31_A(int[] mangSo)
    {
        Console.WriteLine("\n--- Câu a: Đếm số lượng phần tử ---");

        int tongSoPhanTu = mangSo.Count();
        int soPhanTuChan = mangSo.Count(n => n % 2 == 0);
        int soPhanTuLe = mangSo.Count(n => n % 2 != 0);

        Console.WriteLine($"Tổng số phần tử  : {tongSoPhanTu}");
        Console.WriteLine($"Số phần tử chẵn  : {soPhanTuChan}");
        Console.WriteLine($"Số phần tử lẻ    : {soPhanTuLe}");
    }
     public static void Bai31_B(int[] mangSo)
    {
        Console.WriteLine("\n--- Câu b: Tổng, Giá trị lớn nhất, Giá trị nhỏ nhất ---");

        int tongGiaTri = mangSo.Sum();
        int giaTriLonNhat = mangSo.Max();
        int giaTriNhoNhat = mangSo.Min();

        Console.WriteLine($"Tổng giá trị     : {tongGiaTri}");
        Console.WriteLine($"Giá trị lớn nhất : {giaTriLonNhat}");
        Console.WriteLine($"Giá trị nhỏ nhất : {giaTriNhoNhat}");
    }
     public static void Bai31_C(int[] mangSo)
    {
        Console.WriteLine("\n--- Câu c: Số giá trị khác nhau ---");

        var danhSachKhacNhau = mangSo.Distinct();
        int soGiaTriKhacNhau = danhSachKhacNhau.Count();

        Console.WriteLine($"Số giá trị khác nhau: {soGiaTriKhacNhau}");
        Console.WriteLine($"Các giá trị độc nhất: {string.Join(", ", danhSachKhacNhau)}");
    }
     public static void Bai31_D(int[] mangSo)
    {
        Console.WriteLine("\n--- Câu d: Phân nhóm theo số dư khi chia cho 5 ---");

        // Method Syntax
        var nhomSoDu = mangSo.GroupBy(n => n % 5)
                            .OrderBy(g => g.Key);

        foreach (var nhom in nhomSoDu)
        {
            Console.WriteLine($"Số dư {nhom.Key}: {string.Join(", ", nhom)}");
        }
    }
}