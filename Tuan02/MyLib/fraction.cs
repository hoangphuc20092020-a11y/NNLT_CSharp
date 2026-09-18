namespace MyLib;

public class Fraction
{
    private int tu; 
    private int mau;
    //constructor hiển nhiên
    public Fraction()
    {
         tu=0;
         mau=1;
    }
    // constructor tham số
    public Fraction(int tu,int mau)
    {
        this.tu = tu;
        this.mau = mau;
    }
    // constructor sao chép
    public Fraction( Fraction f)
    {
        this.tu = f.tu;
        this.mau = f.mau;
    }
    //  override ToString
    public override string ToString()
    {
        return tu + "/" + mau;
    }
    // phân số đối: -A
    public static Fraction operator -(Fraction a)
    {
        return new Fraction(-a.tu, a.mau);
    }
    // Phân số dương: +A
    public static Fraction operator +(Fraction a)
    {
        return new Fraction(a.tu, a.mau);
    }
    //công phân số A + B
    public static Fraction operator +(Fraction a, Fraction b)
    {
        return new Fraction(a.tu*b.mau +b.tu*b.mau,a.mau*b.mau);
    }
    // trừ phấn số A -B
     public static Fraction operator -(Fraction a, Fraction b)
    {
        return new Fraction(a.tu*b.mau -b.tu*b.mau,a.mau*b.mau);
    }
    // A*B
    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(
            a.tu*b.tu,
            a.mau*b.mau
            );
    }
    // A/B
    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(a.tu*b.mau, b.tu*a.mau);
    }

    // A > B
    public static bool operator >(Fraction a, Fraction b)
    {
        return a.tu * b.mau > b.tu*a.mau;
    }

    // A < B
    public static bool operator <(Fraction a, Fraction b)
    {
        return a.tu * b.mau < b.tu * a.mau;
    }
    // A >=B
    public static bool operator >=(Fraction a, Fraction b)
    {
        return a.tu * b.mau >= b.tu * a.mau;
    }
    // A<=B
    public static bool operator <=(Fraction a, Fraction b)
    {
        return a.tu*b.mau <= b.tu*a.mau;
    }
    // A == B
    public static bool operator ==(Fraction a, Fraction b)
    {
        return a.tu*b.mau == b.tu*a.mau;
    }
    // A!=B
    public static bool operator !=(Fraction a, Fraction b)
    {
        return a.tu*b.mau <= b.tu*a.mau;
    }
    public override bool Equals(object? obj)
    {
        if (obj is not Fraction f)
            return false;
        return this == f;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(tu,mau);
    }
}