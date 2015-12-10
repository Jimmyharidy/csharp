using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingThings
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static explicit operator Point3D(Point point)
        {
            return new Point3D(50,50,25);
        }

        public override string ToString() => $"X: {X}";
    }
}
