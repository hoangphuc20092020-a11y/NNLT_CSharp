using MyLib;

Console.Write("Nhap Ho va Ten sinh Vien: ");
String hoTen = Console.ReadLine() ?? "";

Console.Write("Nhap nam sinh: ");
int namSinh = int.Parse(Console.ReadLine() ?? "0");

SinhVien sv = new SinhVien(hoTen, namSinh);
int namHienTai = DateTime.Now.Year;
int tuoi = sv.TinhTuoi(namHienTai);

Console.WriteLine($"ho Ten:{sv.HoTen}");
Console.WriteLine($"nam sinh:{sv.NamSinh}");
Console.WriteLine($"Tuoi:{tuoi}"); 

