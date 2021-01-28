using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Радиус не может быть отрицательным");
                else radius = value;
            }
        }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.Round((Math.PI * radius * radius), 4);
        }
    }
}
