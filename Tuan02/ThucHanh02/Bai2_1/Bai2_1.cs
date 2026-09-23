using System;
using MyLib;

namespace Bai2_1;

class Program
{
static void Main(string[] args)
{
// Tạo ArrayPoint
ArrayPoint arrayPoint = new ArrayPoint();

    // Tạo Point 1
    Point p1 = new Point();
    p1.X = 1;
    p1.Y = 2;

    // Tạo Point 2
    Point p2 = new Point();
    p2.X = 3;
    p2.Y = 4;

    // Tạo Point 3
    Point p3 = new Point();
    p3.X = 5;
    p3.Y = 6;

    // Thêm Point vào ArrayPoint
    arrayPoint.Add(p1);
    arrayPoint.Add(p2);
    arrayPoint.Add(p3);

    // In số lượng Point
    Console.WriteLine("So luong Point: " + arrayPoint.Count);

    // Truy cập Point bằng index
    Console.WriteLine("Point[0]: " + arrayPoint[0]);
    Console.WriteLine("Point[1]: " + arrayPoint[1]);
    Console.WriteLine("Point[2]: " + arrayPoint[2]);

    // Thay đổi Point tại vị trí 1
    Point p4 = new Point();
    p4.X = 10;
    p4.Y = 20;

    arrayPoint[1] = p4;

    Console.WriteLine("\nSau khi thay doi Point[1]:");

    for (int i = 0; i < arrayPoint.Count; i++)
    {
        Console.WriteLine($"Point[{i}]: " + arrayPoint[i]);
    }
}


}
