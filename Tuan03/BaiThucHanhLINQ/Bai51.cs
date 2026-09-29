using System;
using System.Runtime.InteropServices;
namespace BaiThucHanhLINQ;
public static class Bai51
{
    public static void chay()
    {
         List<MonHoc> dsMon = DuLieu.DS_Mon();
         Bai51_A(dsMon);
         Bai51_B(dsMon);
         Bai51_C(dsMon);
         Bai51_D(dsMon);
         


    }
     public static void Bai51_A(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Cau a: Ten cac mon hoc bat dau bang 'Lap trinh' ---");
        var resQuery = from m in dsMon
        where m.TenMon.StartsWith("Lập Trình", StringComparison.OrdinalIgnoreCase)
        select m.TenMon;

        var resMethod = dsMon.Where(m => m.TenMon.StartsWith("Lập Trình", StringComparison.OrdinalIgnoreCase)).
        Select(m=>m.TenMon);
        foreach (var ten in resMethod)
        {
            Console.WriteLine($"-{ten}");
        }
    }
     public static void Bai51_B(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Cau b: Mon thuoc he 'CD' (So tiet giam dan, Ma mon tang dan) ---");
        var resQuery = from m in dsMon
        where m.He == "CD"
        orderby m.SoTiet descending , m.MaMon ascending
        select m;

        var resMethod = dsMon.Where(m=> m.He == "CD").OrderByDescending(m => m.SoTiet).ThenBy(m => m.MaMon);
        foreach (var m in resMethod)
        {
            Console.WriteLine(m);
        }
    }
         public static void Bai51_C(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Cau c: Cac mon chua tu 'web' (Chi lay Ten mon va He) ---");

        var resQuery  = from m in dsMon
        where m.TenMon.Contains("web",StringComparison.OrdinalIgnoreCase)
        select new {m.TenMon, m.He};

        var resMethod =  dsMon.Where(m => m.TenMon.Contains("web", StringComparison.OrdinalIgnoreCase))
        .Select(m => new {m.TenMon,m.He});

        foreach  (var item in resMethod)
        {
            Console.WriteLine($"Môn học: {item.TenMon, 45} | hệ: {item.TenMon}");
        }
    }
         public static void Bai51_D(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Cau d: Cac mon thuoc he 'KTV' (Sap xep Ma mon tang dan) ---");

        // Query Syntax
        var resQuery = from m in dsMon
                       where m.He == "KTV"
                       orderby m.MaMon ascending
                       select m;

        // Method Syntax
        var resMethod = dsMon.Where(m => m.He == "KTV")
                             .OrderBy(m => m.MaMon);

        foreach (var m in resMethod)
        {
            Console.WriteLine(m);
        }
    }
}
    