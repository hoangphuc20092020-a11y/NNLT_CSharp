using MyLib;

namespace Bai1_4;

class Program
{
    static void Main()
    {
        Fraction a = new Fraction(1, 2);
        Fraction b = new Fraction(1, 3);

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.WriteLine("\na + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));

        Console.WriteLine("\n+a = " + (+a));
        Console.WriteLine("-a = " + (-a));

        Console.WriteLine("\nSo sanh:");
        Console.WriteLine("a > b  : " + (a > b));
        Console.WriteLine("a < b  : " + (a < b));
        Console.WriteLine("a >= b : " + (a >= b));
        Console.WriteLine("a <= b : " + (a <= b));
        Console.WriteLine("a == b : " + (a == b));
        Console.WriteLine("a != b : " + (a != b));
    }
}