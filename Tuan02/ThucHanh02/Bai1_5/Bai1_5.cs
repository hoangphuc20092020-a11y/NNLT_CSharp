using System;

namespace Bai1_5;

class Program
{
static void Main(string[] args)
{
// 1. Khởi tạo đơn thức bằng constructor mặc định
Monomial m1 = new Monomial();

    Console.WriteLine("m1 = " + m1);

    // 2. Khởi tạo đơn thức với a và n
    Monomial m2 = new Monomial(3, 4);

    Console.WriteLine("m2 = " + m2);

    // 3. Tính giá trị đơn thức tại x = 2
    double x = 2;
    double result = m2.Evaluate(x);

    Console.WriteLine($"m2({x}) = {result}");

    // 4. Tính đạo hàm
    Monomial derivative = m2.Derivative();

    Console.WriteLine("Dao ham cua m2 = " + derivative);

    // 5. Copy constructor
    Monomial m3 = new Monomial(m2);

    Console.WriteLine("m3 (copy tu m2) = " + m3);
}

}
