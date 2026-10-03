using System;

namespace TH04d
{
    public class PhuongTrinhBacHai
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        // Constructor mặc định
        public PhuongTrinhBacHai()
        {
            A = 0;
            B = 0;
            C = 0;
        }

        // Constructor có tham số
        public PhuongTrinhBacHai(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        // Giải phương trình bậc nhất: ax + b = 0
        public string GiaiBacNhat()
        {
            if (A == 0)
            {
                if (B == 0)
                {
                    return "Phương trình có vô số nghiệm.";
                }

                return "Phương trình vô nghiệm.";
            }

            double x = -B / A;

            return "x = " + x;
        }

        // Giải phương trình bậc hai: ax² + bx + c = 0
        public string GiaiBacHai()
        {
            // Nếu a = 0 thì trở thành phương trình bậc nhất
            if (A == 0)
            {
                return GiaiBacNhat();
            }

            double delta = B * B - 4 * A * C;

            if (delta < 0)
            {
                return "Phương trình vô nghiệm.";
            }

            if (delta == 0)
            {
                double x = -B / (2 * A);

                return "Nghiệm kép x = " + x;
            }

            double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double x2 = (-B - Math.Sqrt(delta)) / (2 * A);

            return "x1 = " + x1 + "; x2 = " + x2;
        }
    }
}