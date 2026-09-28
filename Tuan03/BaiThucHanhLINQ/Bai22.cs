using System;
namespace BaiThucHanhLINQ;
public class Bai22
{
    public static void chay()
    {
         Console.WriteLine("BAi2.2");
         string[] mangChuoi = { "đầu", "lòng", "hai", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thủy", "Vân" };
         Bai22_A(mangChuoi);
         Bai22_B(mangChuoi);
         Bai22_C(mangChuoi);
         Bai22_D(mangChuoi);
    }
    public static void Bai22_A(string [] mangChuoi)
    {
        Console.WriteLine("\n--- Câu a: Các phần tử có 4 ký tự, sắp xếp tăng dần theo ký tự đầu ---");
        var resQuery = from s in mangChuoi
                        where s.Length == 4
                        select s;
        var resMethod = mangChuoi.Where(s => s.Length==4);
        //resMethod.ToList().ForEach(Console.WriteLine);
        Console.WriteLine("Query Syntax  : " + string.Join(", ", resQuery));
        Console.WriteLine("Method Syntax : " + string.Join(", ", resMethod));
    }
    public static void Bai22_B(string [] mangChuoi)
    {
        Console.WriteLine("\n--- Câu b: Biến đổi dạng <chữ thường> - <CHỮ HOA> ---");

        // Query Syntax
        var resQuery = from s in mangChuoi
                        select $"{s.ToLower()} - {s.ToUpper()}";

        // Method Syntax
        var resMethod = mangChuoi.Select(s => $"{s.ToLower()} - {s.ToUpper()}");

        Console.WriteLine("Query Syntax  :\n" + string.Join("\n", resQuery));
        Console.WriteLine("\nMethod Syntax :\n" + string.Join("\n", resMethod));
    }
    public static void Bai22_C(string[] mangChuoi)
    {
         Console.WriteLine("\n--- Câu C liệt kê các phân tử có chữ u ---");

        // Query Syntax
        var resQuery = from s in mangChuoi
                        where s.Contains('u') || s.Contains('U')
                        select s;

        // Method Syntax
        var resMethod = mangChuoi.Where(s => s.Contains("u") || s.Contains("U"));

        Console.WriteLine("Query Syntax  :\n" + string.Join("\n", resQuery));
        Console.WriteLine("\nMethod Syntax :\n" + string.Join("\n", resMethod));
    }
    public static void Bai22_D (string[] mangChuoi )
    {
        Console.WriteLine("\n--- Câu D chọn các phần tử bắt đầu bằng chữ in hoa. ---");

        // Query Syntax
        var resQuery = from s in mangChuoi
                        where char.IsUpper(s[0])
                        select s;

        // Method Syntax
        var resMethod = mangChuoi.Where(s => char.IsUpper(s[0]));

        Console.WriteLine("Query Syntax  :\n" + string.Join("\n", resQuery));
        Console.WriteLine("\nMethod Syntax :\n" + string.Join("\n", resMethod));
    }
}