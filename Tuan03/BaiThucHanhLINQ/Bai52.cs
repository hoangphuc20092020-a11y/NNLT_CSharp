using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLINQ;

public class Bai52
{
    public static void chay()
    {
        Console.WriteLine("\n=== BÀI 5.2: THỐNG KÊ TRÊN LIST<MONHOC> ===");

        List<MonHoc> dsMon = DuLieu.DS_Mon();

        Bai52_A(dsMon);
        Bai52_B(dsMon);
        Bai52_C(dsMon);
        Bai52_D(dsMon);
        Bai52_E(dsMon);
        Bai52_F(dsMon);
        Bai52_G(dsMon);
        Bai52_H(dsMon);
        Bai52_I(dsMon);
        Bai52_J(dsMon);
        Bai52_K(dsMon);
    }

    // a. Cho biết tổng số môn hiện có
    public static void Bai52_A(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu a: Tổng số môn hiện có ---");
        int tongSoMon = dsMon.Count();
        Console.WriteLine($"Tổng số môn: {tongSoMon}");
    }

    // b. Đếm số môn có tên bắt đầu bằng "Lập trình"
    public static void Bai52_B(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu b: Đếm số môn bắt đầu bằng 'Lập trình' ---");
        int count = dsMon.Count(m => m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine($"Số môn bắt đầu bằng 'Lập trình': {count}");
    }

    // c. Tính tổng số tiết của hệ Kỹ thuật viên (KTV)
    public static void Bai52_C(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu c: Tổng số tiết hệ KTV ---");
        int tongTietKTV = dsMon.Where(m => m.He == "KTV").Sum(m => (int)m.SoTiet);
        Console.WriteLine($"Tổng số tiết hệ KTV: {tongTietKTV}");
    }

    // d. Cho biết tổng số môn của mỗi hệ: Hệ, Tổng số môn
    public static void Bai52_D(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu d: Tổng số môn của mỗi hệ ---");
        var res = dsMon.GroupBy(m => m.He)
                       .Select(g => new { He = string.IsNullOrEmpty(g.Key) ? "(Trống)" : g.Key, TongSoMon = g.Count() });

        foreach (var item in res)
        {
            Console.WriteLine($"Hệ: {item.He,-7} | Tổng số môn: {item.TongSoMon}");
        }
    }

    // e. Nhóm theo Số tiết; in Số tiết và Tổng số môn, sắp xếp giảm dần theo Số tiết
    public static void Bai52_E(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu e: Thống kê số môn theo Số tiết (Giảm dần) ---");
        var res = dsMon.GroupBy(m => m.SoTiet)
                       .OrderByDescending(g => g.Key)
                       .Select(g => new { SoTiet = g.Key, TongSoMon = g.Count() });

        foreach (var item in res)
        {
            Console.WriteLine($"Số tiết: {item.SoTiet,-3} | Số môn: {item.TongSoMon}");
        }
    }

    // f. Cho biết thông tin môn học có số tiết cao nhất
    public static void Bai52_F(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu f: Thông tin môn học có số tiết cao nhất ---");
        byte maxTiet = dsMon.Max(m => m.SoTiet);
        var dsMaxTiet = dsMon.Where(m => m.SoTiet == maxTiet);

        foreach (var m in dsMaxTiet)
        {
            Console.WriteLine(m);
        }
    }

    // g. Thống kê theo Hệ: tổng số môn, tổng số tiết, số tiết cao nhất, số tiết thấp nhất
    public static void Bai52_G(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu g: Thống kê chi tiết theo Hệ ---");
        var res = dsMon.GroupBy(m => m.He)
                       .Select(g => new {
                           He = string.IsNullOrEmpty(g.Key) ? "(Trống)" : g.Key,
                           TongSoMon = g.Count(),
                           TongSoTiet = g.Sum(m => (int)m.SoTiet),
                           SoTietMax = g.Max(m => m.SoTiet),
                           SoTietMin = g.Min(m => m.SoTiet)
                       });

        foreach (var item in res)
        {
            Console.WriteLine($"Hệ: {item.He,-7} | Số môn: {item.TongSoMon,-2} | Tổng tiết: {item.TongSoTiet,-3} | Max: {item.SoTietMax,-3} | Min: {item.SoTietMin}");
        }
    }

    // h. Liệt kê các môn học được phân nhóm theo Hệ
    public static void Bai52_H(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu h: Liệt kê các môn học phân nhóm theo Hệ ---");
        var nhomHe = dsMon.GroupBy(m => m.He);

        foreach (var group in nhomHe)
        {
            string tenHe = string.IsNullOrEmpty(group.Key) ? "(Chưa phân hệ)" : group.Key;
            Console.WriteLine($"\n[ HỆ: {tenHe} ]");
            foreach (var m in group)
            {
                Console.WriteLine($"   {m}");
            }
        }
    }

    // i. Liệt kê các môn học được phân nhóm theo Số tiết và tăng dần theo Số tiết
    public static void Bai52_I(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu i: Liệt kê các môn học phân nhóm theo Số tiết (Tăng dần) ---");
        var nhomTiet = dsMon.GroupBy(m => m.SoTiet)
                            .OrderBy(g => g.Key);

        foreach (var group in nhomTiet)
        {
            Console.WriteLine($"\n[ SỐ TIẾT: {group.Key} ]");
            foreach (var m in group)
            {
                Console.WriteLine($"   {m}");
            }
        }
    }

    // j. Với hệ KTV, phân nhóm theo học phần HP2, HP3, HP4, HP5; sắp xếp theo Mã môn
    public static void Bai52_J(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu j: Hệ KTV phân nhóm theo Học phần (HP2, HP3, HP4, HP5) ---");
        var res = dsMon.Where(m => m.He == "KTV" && m.MaMon.Length >= 3)
                       .GroupBy(m => m.MaMon.Substring(0, 3)) // Lấy 3 ký tự đầu: HP2, HP3, HP4, HP5
                       .OrderBy(g => g.Key);

        foreach (var group in res)
        {
            Console.WriteLine($"\n[ HỌC PHẦN: {group.Key} ]");
            foreach (var m in group.OrderBy(x => x.MaMon))
            {
                Console.WriteLine($"   {m}");
            }
        }
    }

    // k. Phân nhóm theo Hệ, chỉ lấy các môn có Số tiết > 40; trong mỗi nhóm sắp xếp theo Mã môn
    public static void Bai52_K(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu k: Phân nhóm theo Hệ (Số tiết > 40), sắp xếp Mã môn ---");
        var res = dsMon.Where(m => m.SoTiet > 40)
                       .GroupBy(m => m.He);

        foreach (var group in res)
        {
            string tenHe = string.IsNullOrEmpty(group.Key) ? "(Chưa phân hệ)" : group.Key;
            Console.WriteLine($"\n[ HỆ: {tenHe} ]");
            foreach (var m in group.OrderBy(x => x.MaMon))
            {
                Console.WriteLine($"   {m}");
            }
        }
    }
}