using MyLib;
namespace Bai1_5;
public class Monomial
{
    private double a;
    private int n;

    public Monomial()
    {
        this.a = 0;
        this.n = 0;
    }

    public Monomial(double a, int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "So mu phai khong am.");
        }

        this.a = a;
        this.n = n;
    }

    public Monomial(Monomial monomial)
    {
        this.a = monomial.a;
        this.n = monomial.n;
    }

    public double Evaluate(double x)
    {
        return this.a * Math.Pow(x, this.n);
    }

    public Monomial Derivative()
    {
        if (this.n == 0)
        {
            return new Monomial(0, 0);
        }

        return new Monomial(this.a * this.n, this.n - 1);
    }

    public override string ToString()
    {
        return $"{this.a}x^{this.n}";
    }
}