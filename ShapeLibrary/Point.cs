using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
    }
}
