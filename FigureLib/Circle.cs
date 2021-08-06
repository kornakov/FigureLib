using System;

namespace FigureLib
{
    public class Circle : IArea
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = IArea.CheckSide(radius);
        }
        public double CalculateArea() => Math.PI * radius * radius;
    }
}
