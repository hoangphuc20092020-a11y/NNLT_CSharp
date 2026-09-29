using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLINQ;

public class Bai62
{
    public static void chay()
    {
        Console.WriteLine("\n=== BÀI 6.2: JOIN VÀ CÁC TOÁN TỬ TẬP HỢP ===");

        List<MonHoc> dsMon = DuLieu.DS_Mon();
        List<He> dsHe = DuLieuHe.DS_He();

        Bai62_A(dsMon, dsHe);
        Bai62_B(dsMon, dsHe);
        Bai62_C(dsMon, dsHe);
        Bai62_D(dsMon, dsHe);
        Bai62_E(dsMon, dsHe);
        Bai62_F(dsMon, dsHe);
        Bai62_G(dsMon);
        Bai62_H(dsMon);
        Bai62_I(dsMon, dsHe);
    }

    // a. Dùng join để liệt kê: Tên hệ, Mã môn, Tên môn.
    public static void Bai62_A(List<MonHoc> dsMon, List<He> dsHe)
    {
        Console.WriteLine("\n--- Câu a: Inner Join (Tên hệ, Mã môn, Tên môn) ---");

        var res = from h in dsHe
                  join m in dsMon on h.MaHe equals m.He
                  select new { h.TenHe, m.MaMon, m.TenMon };

        foreach (var item in res)
        {
            Console.WriteLine($"Hệ: {item.TenHe,-20} | Mã: {item.MaMon,-6} | Môn: {item.TenMon}");
        }
    }

    // b. Liệt kê cả những hệ chưa có môn học (left outer join với GroupJoin + DefaultIfEmpty).
    public static void Bai62_B(List<MonHoc> dsMon, List<He> dsHe)
    {
        Console.WriteLine("\n--- Câu b: Left Outer Join (Bao gồm hệ chưa có môn học) ---");

        var res = from h in dsHe
                  join m in dsMon on h.MaHe equals m.He into groupMon
                  from subMon in groupMon.DefaultIfEmpty()
                  select new
                  {
                      TenHe = h.TenHe,
                      MaMon = subMon != null ? subMon.MaMon : "(Chưa có)",
                      TenMon = subMon != null ? subMon.TenMon : "(Chưa có môn học)"
                  };

        foreach (var item in res)
        {
            Console.WriteLine($"Hệ: {item.TenHe,-20} | Mã: {item.MaMon,-6} | Môn: {item.TenMon}");
        }
    }

    // c. Liệt kê cả hệ chưa có môn học và môn học chưa khai báo hệ (Full Outer Join).
    public static void Bai62_C(List<MonHoc> dsMon, List<He> dsHe)
    {
        Console.WriteLine("\n--- Câu c: Full Outer Join (Liệt kê cả 2 chiều chưa ghép nối) ---");

        // Left Join
        var leftJoin = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into groupMon
                       from subMon in groupMon.DefaultIfEmpty()
                       select new
                       {
                           TenHe = h.TenHe,
                           MaMon = subMon != null ? subMon.MaMon : "(Chưa có)",
                           TenMon = subMon != null ? subMon.TenMon : "(Chưa có môn học)"
                       };

        // Danh sách môn chưa thuộc hệ nào trong dsHe
        var monKhoeHe = from m in dsMon
                        where !dsHe.Any(h => h.MaHe == m.He)
                        select new
                        {
                            TenHe = "(Chưa phân hệ)",
                            MaMon = m.MaMon,
                            TenMon = m.TenMon
                        };

        var fullJoin = leftJoin.Union(monKhoeHe);

        foreach (var item in fullJoin)
        {
            Console.WriteLine($"Hệ: {item.TenHe,-20} | Mã: {item.MaMon,-6} | Môn: {item.TenMon}");
        }
    }

    // d. Chỉ liệt kê những hệ chưa có môn học và những môn học chưa khai báo hệ.
    public static void Bai62_D(List<MonHoc> dsMon, List<He> dsHe)
    {
        Console.WriteLine("\n--- Câu d: Chỉ lấy các hệ không có môn HOẶC môn không có hệ ---");

        var heKhongMon = dsHe.Where(h => !dsMon.Any(m => m.He == h.MaHe))
                             .Select(h => new { TenHe = h.TenHe, MaMon = "-", TenMon = "(Hệ chưa có môn học)" });

        var monKhongHe = dsMon.Where(m => !dsHe.Any(h => h.MaHe == m.He))
                             .Select(m => new { TenHe = "(Chưa thuộc hệ nào)", MaMon = m.MaMon, TenMon = m.TenMon });

        var res = heKhongMon.Concat(monKhongHe);

        foreach (var item in res)
        {
            Console.WriteLine($"Hệ: {item.TenHe,-20} | Mã: {item.MaMon,-6} | Môn: {item.TenMon}");
        }
    }

    // e. Lấy 5 môn học đầu tiên có số tiết giảm dần; hiển thị Tên hệ, Mã môn, Tên môn, Số tiết.
    public static void Bai62_E(List<MonHoc> dsMon, List<He> dsHe)
    {
        Console.WriteLine("\n--- Câu e: Top 5 môn có Số tiết giảm dần ---");

        var res = (from m in dsMon
                   join h in dsHe on m.He equals h.MaHe into groupHe
                   from subHe in groupHe.DefaultIfEmpty()
                   orderby m.SoTiet descending
                   select new
                   {
                       TenHe = subHe != null ? subHe.TenHe : "(Chưa phân)",
                       m.MaMon,
                       m.TenMon,
                       m.SoTiet
                   }).Take(5);

        foreach (var item in res)
        {
            Console.WriteLine($"Hệ: {item.TenHe,-20} | Mã: {item.MaMon,-6} | Môn: {item.TenMon,-42} | Tiết: {item.SoTiet}");
        }
    }

    // f. Cho biết tổng số môn học của mỗi hệ: Mã hệ, Tên hệ, Tổng số môn.
    public static void Bai62_F(List<MonHoc> dsMon, List<He> dsHe)
    {
        Console.WriteLine("\n--- Câu f: Thống kê số môn của mỗi hệ ---");

        var res = from h in dsHe
                  join m in dsMon on h.MaHe equals m.He into groupMon
                  select new
                  {
                      h.MaHe,
                      h.TenHe,
                      TongSoMon = groupMon.Count()
                  };

        foreach (var item in res)
        {
            Console.WriteLine($"Mã hệ: {item.MaHe,-5} | Tên hệ: {item.TenHe,-20} | Tổng số môn: {item.TongSoMon}");
        }
    }

    // g. Cho biết có bao nhiêu loại Số tiết khác nhau trong danh sách môn học.
    public static void Bai62_G(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu g: Số loại Số tiết khác nhau ---");

        var loaiSoTiet = dsMon.Select(m => m.SoTiet).Distinct();
        Console.WriteLine($"Có {loaiSoTiet.Count()} loại số tiết khác nhau: {string.Join(", ", loaiSoTiet.OrderBy(x => x))}");
    }

    // h. Tìm môn học đầu tiên có tên bắt đầu bằng "Lập trình".
    public static void Bai62_H(List<MonHoc> dsMon)
    {
        Console.WriteLine("\n--- Câu h: Môn học đầu tiên bắt đầu bằng 'Lập trình' ---");

        var monDauTien = dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase));

        if (monDauTien != null)
        {
            Console.WriteLine($"Tìm thấy: {monDauTien}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy môn học thỏa mãn.");
        }
    }

    // i. Liệt kê các môn theo từng hệ, đánh số thứ tự trong mỗi nhóm.
    public static void Bai62_I(List<MonHoc> dsMon, List<He> dsHe)
    {
        Console.WriteLine("\n--- Câu i: Danh sách môn theo từng hệ (Có đánh STT) ---");

        var res = from h in dsHe
                  join m in dsMon on h.MaHe equals m.He into groupMon
                  select new
                  {
                      He = h,
                      DanhSachMon = groupMon.ToList()
                  };

        foreach (var item in res)
        {
            Console.WriteLine($"\n[ HỆ: {item.He.TenHe} ({item.He.MaHe}) ]");
            if (item.DanhSachMon.Count == 0)
            {
                Console.WriteLine("   (Không có môn học nào)");
            }
            else
            {
                int stt = 1;
                foreach (var mon in item.DanhSachMon)
                {
                    Console.WriteLine($"   {stt++}. {mon}");
                }
            }
        }
    }
}