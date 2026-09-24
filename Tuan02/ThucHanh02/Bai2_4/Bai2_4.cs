using System;
using System.Collections.Generic;

namespace Bai2_4;

class Program
{
static void Main(string[] args)
{
// Nhập số dòng
Console.Write("Nhap so dong: ");
int rows;


    while (!int.TryParse(Console.ReadLine(), out rows) || rows < 0)
    {
        Console.Write("So dong khong hop le. Nhap lai: ");
    }

    // Nhập số cột
    Console.Write("Nhap so cot: ");
    int columns;

    while (!int.TryParse(Console.ReadLine(), out columns) || columns < 0)
    {
        Console.Write("So cot khong hop le. Nhap lai: ");
    }

    // Tạo ma trận
    IntegerMatrix matrix = new IntegerMatrix(rows, columns);

    // Nhập ma trận
    Console.WriteLine("\n===== NHAP MA TRAN =====");
    matrix.Input();

    // Xuất ma trận
    Console.WriteLine("\n===== MA TRAN VUA NHAP =====");
    matrix.Output();

    // Kiểm tra Rows và Columns
    Console.WriteLine($"So dong: {matrix.Rows}");
    Console.WriteLine($"So cot: {matrix.Columns}");

    // Truy cập phần tử bằng indexer
    if (matrix.Rows > 0 && matrix.Columns > 0)
    {
        Console.WriteLine(
            $"Phan tu [0, 0]: {matrix[0, 0]}"
        );

        Console.WriteLine(
            $"Phan tu [{matrix.Rows - 1}, {matrix.Columns - 1}]: " +
            $"{matrix[matrix.Rows - 1, matrix.Columns - 1]}"
        );
    }

    // Copy constructor
    IntegerMatrix copyMatrix = new IntegerMatrix(matrix);

    Console.WriteLine("\n===== MA TRAN SAO CHEP =====");
    copyMatrix.Output();

    // Lấy các số nguyên tố
    List<int> primeNumbers = matrix.PrimeNumbers();

    Console.WriteLine("\n===== CAC SO NGUYEN TO =====");

    if (primeNumbers.Count == 0)
    {
        Console.WriteLine("Khong co so nguyen to.");
    }
    else
    {
        Console.WriteLine(string.Join(" ", primeNumbers));
    }
}

}
