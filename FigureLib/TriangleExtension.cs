using System.Collections.Generic;
using System.Linq;

namespace FigureLib
{
    public static class TriangleExtension
    {
        public static bool IsRight(this Triangle triangle)
        {
            var list = new List<double> { triangle.A, triangle.B, triangle.C };
            list.Sort();
            return list.Last() * list.Last() == list.First() * list.First() + list[1] * list[1];
        }
    }
}
