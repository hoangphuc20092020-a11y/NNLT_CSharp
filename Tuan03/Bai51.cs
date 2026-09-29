using System;
using System.Runtime.InteropServices;
namespace BaiThucHanhLINQ;
public static class Bai51
{
    public static void chay()
    {
         List<MonHoc> dsMon = DuLieu.DS_Mon;
         Bai51_A(dsMon);

    }
     public static void Bai51_A(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Cau a: Ten cac mon hoc bat dau bang 'Lap trinh' ---");
        var resQuery = from m in dsMon
        where m.TenMon.StartsWith("Lập Trình", StringComparison.OrdinalIgnoreCase)
        select m.TenMon;

        var resMethod = sdMon.where(m => m.TenMon.StartsWith("LapTrinh", StringComparison.OrdinalIgnoreCase)).select(m=>m.TenMon);
        foreach (var m in resMethod)
        {
            Console.WriteLine(m);
        }
    }
     public static void Bai51_B(List<MonHoc> dsMon)
    {
        
    }
         public static void Bai51_C(List<MonHoc> dsMon)
    {
        
    }
         public static void Bai51_D(List<MonHoc> dsMon)
    {
        
    }
}
    