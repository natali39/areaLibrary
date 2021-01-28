using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Значение сторон должно быть больше нуля");

            if (IsExists(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else throw new ArgumentException("Треугольник с такими сторонами не существует");
        }

        private bool IsExists(double a, double b, double c)
        {
            return (a + b) > c && (b + c) > a && (a + c) > b;
        }

        public override double CalculateArea()
        {
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 4);
        }

        public bool IsRightTriangle()
        {
            return (a * a + b * b == c * c) || (c * c + b * b == a * a) || (a * a + c * c == b * b);
        }
    }
}
