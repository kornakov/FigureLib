using System;

namespace FigureLib
{
    public class Triangle : IArea
    {
        readonly double a;
        readonly double b;
        readonly double c;

        public double A => a;
        public double B => b;
        public double C => c;

        public Triangle(double a, double b, double c)
        {
            this.a = IArea.CheckSide(a);
            this.b = IArea.CheckSide(b);
            this.c = IArea.CheckSide(c);
            // По хорошему здесь ещё бы проверить, что это треугольник с помощью неравенства треугольника
        }
        public double CalculateArea()
        {
            var semiperimeter = CalculatePerimeter(a, b, c) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
        }

        private static double CalculatePerimeter(double side1, double side2, double side3) => side1 + side2 + side3;
    }
}
