using MyLib;
namespace Bai1_2;
class Program
{
    static void Main()
    {
        Point A = new Point();
        Point B = new Point();
        Console.WriteLine("Enter Point A: ");
        A.Input();
        Console.WriteLine("\nEnter Point B: ");
        B.Input();
        // output two Point
        Console.WriteLine("\nPoint A: " + A);
        Console.WriteLine("Point B: "+B);

        // sum
        Point C =  A + B;
        Console.WriteLine("\nA+B= "+C);
        // subtraction
        Point D = A - B;
        Console.WriteLine("\nA_B= "+D);
        // lấy âm 
        Point E = -A;
        Console.WriteLine("\nLay am A="+A);
        // distance member
        double d1  = A.Distance(B);
        Console.WriteLine("\n(menber) d1="+d1);
        // distance static
        double d2 = Point.Distance(A,B);
        Console.WriteLine("\n(static) d2= "+d2);
        // midPoint - member
        Point I1 = A.MidPoint(B);
        Console.WriteLine("\n(member) I1= " + I1);
        // MidPoint - static
        Point I2 = Point.MidPoint(A,B);
        Console.WriteLine("\n(static) I2= "+I2);
        
    }
}