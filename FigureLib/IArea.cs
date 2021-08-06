using System;

namespace FigureLib
{
    public interface IArea
    {
        public double CalculateArea();

        public static double CheckSide(double side)
        {
            if (side <= 0) throw new ArgumentException();
            return side;
        }
    }
}
