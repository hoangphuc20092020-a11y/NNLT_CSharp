using System;
using System.Collections.Generic;

namespace BaiThucHanhLINQ;

// Bài 6.1: Xây dựng lớp He
public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";

    public override string ToString()
    {
        return $"[{MaHe,-4}] {TenHe}";
    }
}

public class DuLieuHe
{
    // Tạo phương thức DS_He() trả về List<He>
    public static List<He> DS_He()
    {
        return new List<He>
        {
            new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
            new He { MaHe = "CD",  TenHe = "Chuyên đề" },
            new He { MaHe = "OT",  TenHe = "Chứng chỉ quốc tế" }
        };
    }
}