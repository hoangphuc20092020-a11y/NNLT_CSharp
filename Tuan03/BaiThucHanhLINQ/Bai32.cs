using System;
namespace BaiThucHanhLINQ;
public class Bai32
{
    public static void chay()
    
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ in tiếng Việt chuẩn trên Console
        Console.WriteLine("=== BÀI 3.2: THỐNG KÊ MẢNG CHUỖI ===");
        string[] monAn = {
            "Nước Cà phê", "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
            "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
            "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang"
        };
        Bai32_A(monAn);
        Bai32_B(monAn);
        Bai32_C(monAn);
    }
    private static void Bai32_A(string[] monAn)
    {
        Console.WriteLine("\n--- Câu a: Món ăn ngắn nhất và dài nhất ---");
        int minLen = monAn.Min(s => s.Length);
        int maxLen = monAn.Max(s=> s.Length);


        var monNganNhat = monAn.Where(s => s.Length == minLen);
        var monDaiNhat = monAn.Where(s => s.Length == maxLen);

        Console.WriteLine($"Chiều dài ngắn nhất ({minLen} ký tự): " + string.Join(", ", monNganNhat));
        Console.WriteLine($"Chiều dài dài nhất ({maxLen} ký tự) : " + string.Join(", ", monDaiNhat));
    }
    private static void Bai32_B(string[] monAn)
    {
        Console.WriteLine("\n--- Câu b: Phân nhóm theo từ đầu tiên của tên món ---");

        // Tách lấy từ đầu tiên bằng cách dùng Split(' ')[0]
        var nhomMonAn = monAn.GroupBy(m => m.Split(' ')[0]);

        foreach (var nhom in nhomMonAn)
        {
            Console.WriteLine($"\n[Nhóm '{nhom.Key}'] ({nhom.Count()} món):");
            foreach (var item in nhom)
            {
                Console.WriteLine($"  - {item}");
            }
        }
    }
    private static void Bai32_C(string[] monAn)
    {
        Console.WriteLine("\n--- Câu c: Đếm số phần tử có từ đầu tiên là 'Bánh' ---");

        // Method Syntax
        int soLuongBanh = monAn.Count(m => m.StartsWith("Bánh ") || m.Split(' ')[0] == "Bánh");

        Console.WriteLine($"Số món ăn có từ đầu tiên là 'Bánh': {soLuongBanh}");
    }
    
}