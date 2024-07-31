using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public
     static Point GetOrigin()
        {
            return new Point(0, 0, 0);
        }

        public double GetDistanceFromOrigin()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public double GetDistanceFromPoint(Point other)
        {
            double deltaX = other.X - X;
            double deltaY = other.Y - Y;
            double deltaZ = other.Z - Z;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

        }
    }

}
