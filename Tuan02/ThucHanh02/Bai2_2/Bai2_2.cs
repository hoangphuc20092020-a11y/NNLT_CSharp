
using System;

namespace Bai2_2;

class Program
{
static void Main(string[] args)
{
// Tạo danh sách người
PersonList list = new PersonList();

    // Nhập danh sách
    list.Input();

    // Xuất danh sách vừa nhập
    Console.WriteLine("\n===== DANH SACH NGUOI =====");
    list.Output();

    // Lấy danh sách người còn sống
    PersonList livingList = list.LivingPeople();

    // Xuất danh sách người còn sống
    Console.WriteLine("\n===== DANH SACH NGUOI CON SONG =====");
    livingList.Output();
}


}
