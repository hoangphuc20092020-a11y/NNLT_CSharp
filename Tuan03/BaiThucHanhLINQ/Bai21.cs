using System;

namespace BaiThucHanhLINQ;
public static class Bai21
{
    public static void chay()
    {
        Console.WriteLine("BAi2.1");
        int[] mangso = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

        Bai21_A(mangso);
        
        Bai21_B(mangso);
        
        Bai21_C(mangso);
    }
    private static void Bai21_A(int [] mangso)
    {
        var resQuery = from so in mangso
                        where so % 4 == 0 && so % 3 == 0
                        select so;
        var resMethod = mangso.Where(so => so % 4==0 && so % 3 ==0);
        Console.WriteLine(
            "Query Syntax  : " + string.Join(", ", resQuery)
        );

        Console.WriteLine(
            "Method Syntax : " + string.Join(", ", resMethod)
        );
    }
    private static void Bai21_B(int [] mangso)
    {
        var cauB_Query = from so in mangso 
        where so <= 3
        select so;

        var cauB_Method = mangso.Where(so => so <= 3);
        Console.WriteLine("Query Syntax  : " + string.Join(", ", cauB_Query));
        Console.WriteLine("Method Syntax : " + string.Join(", ", cauB_Method));
        
    }
    private static void Bai21_C(int [] mangso)
    {
        var cauC_Query = from so in mangso
        select (so % 2 == 0) ? so/2 : so;

        var cauC_Method = mangso.Select(so => (so % 2 == 0) ? so/2:so);
        Console.WriteLine("Query Syntax  : " + string.Join(", ", cauC_Query));
        Console.WriteLine("Method Syntax : " + string.Join(", ", cauC_Method));
    }
}
