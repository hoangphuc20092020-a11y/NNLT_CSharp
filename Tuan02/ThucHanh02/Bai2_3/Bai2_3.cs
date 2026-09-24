using System;
using System.Collections.Generic;

namespace Bai2_3;

class Program
{
static void Main(string[] args)
{
// Nhập số lượng phần tử
Console.Write("Nhap so luong phan tu: ");
int n;

    while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
    {
        Console.Write("So luong khong hop le. Nhap lai: ");
    }

    // Tạo IntegerArray
    IntegerArray array = new IntegerArray(n);

    // Nhập các phần tử
    array.Input();

    // Xuất mảng
    Console.WriteLine("\n===== MANG VUA NHAP =====");
    array.Output();

    // In số lượng phần tử
    Console.WriteLine($"So luong phan tu: {array.Length}");

    // Truy cập phần tử bằng indexer
    if (array.Length > 0)
    {
        Console.WriteLine($"Phan tu dau tien: {array[0]}");
        Console.WriteLine($"Phan tu cuoi cung: {array[array.Length - 1]}");
    }

    // Copy constructor
    IntegerArray copyArray = new IntegerArray(array);

    Console.WriteLine("\n===== MANG SAO CHEP =====");
    copyArray.Output();

    // Lấy các số chẵn
    List<int> evenNumbers = array.EvenNumbers();

    Console.WriteLine("\n===== CAC SO CHAN =====");

    if (evenNumbers.Count == 0)
    {
        Console.WriteLine("Khong co so chan.");
    }
    else
    {
        Console.WriteLine(string.Join(" ", evenNumbers));
    }
}


}
