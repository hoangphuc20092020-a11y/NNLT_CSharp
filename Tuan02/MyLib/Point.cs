using System.Numerics;

namespace MyLib;

public class Point
{
    // FIELD
    private double x;
    private double y;
    // constructor
    public Point()
    {
        x=0;
        y=0;
    }
    // property
    public double X
    {
        get{return x;}
        set{x = value;}
    }
    public double Y
    {
        get{return y;}
        set{y = value;}
    }

    public void Input()
    {
        Console.Write("Nhap x= ");
        x = double.Parse(Console.ReadLine()!);
        Console.Write("Nhap y= ");
        y = double.Parse(Console.ReadLine()!);
    }

    public void Output()
    {
        Console.WriteLine($"{x},{y}");
    }

    // override tostring
    public override string ToString()
    {
        return $"({x},{y})";
    }

    // OPERATOR + 
    // A + B
    public static Point operator +(Point a, Point b)
    {
        Point result = new Point();
        result.x = a.x + b.x;
        result.y = a.y + b.y;
        return result;
    }
    // OPERATOR
    // A - B
    public static Point operator -(Point a, Point b)
    {
        Point result = new Point();
        result.x = a.x - b.x;
        result.y = a.y - b.y;
        return result;
    }
    // OPERATOR
    // -A
    public static Point operator -(Point a)
    {
        Point result = new Point();
        result.x = -a.x;
        result.y = -a.y;
        return result;
    }
    // distance - member
    public double Distance(Point other)
    {
        double dx = x - other.x;
        double dy = y - other.y;
        return Math.Sqrt(dx*dx+dy*dy);
    }
    // distance - member
    public static double Distance(Point a, Point b)
    {
        double dx = a.x - b.x;
        double dy = a.y - b.y;
        return Math.Sqrt(dx*dx+dy*dy);
    }

    //midPoint - member
    public Point MidPoint(Point other)
    {
        Point result = new Point();
        result.x = (x + other.x)/2;
        result.y = (y + other.y)/2;
        return result;
    }
    public static Point MidPoint(Point a, Point b)
    {
        Point result = new Point();
        result.x = (a.x + b.x)/2;
        result.y = (a.y + b.y)/2;
        return result;
    }
}