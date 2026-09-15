using MyLib;

Console.Write("Nhap ho ten: ");
string hoTen = Console.ReadLine() ?? "";

Console.Write("Nhap nam sinh: ");
int namSinh = int.Parse(Console.ReadLine() ?? "0");

SinhVien sv = new SinhVien(hoTen, namSinh);

int namHienTai = DateTime.Now.Year;
int tuoi = sv.TinhTuoi(namHienTai);

Console.WriteLine($"Ho ten: {sv.HoTen}");
Console.WriteLine($"Nam sinh: {sv.NamSinh}");
Console.WriteLine($"Tuoi: {tuoi}");