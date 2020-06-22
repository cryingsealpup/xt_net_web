using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_development
{   
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            if (!(Math.Abs(x) >= Field.width || Math.Abs(y) >= Field.heigth))
            { this.X = Math.Abs(x); this.Y = Math.Abs(y); }
            else 
            { this.X = Math.Abs(x) - 1; this.Y = Math.Abs(y) - 1; }
        }

        public static bool operator ==(Point firstPoint, Point secondPoint)
        {
            if (firstPoint is null || secondPoint is null) return false;

            return firstPoint.X == secondPoint.X && firstPoint.Y == secondPoint.Y;
        }

        public static bool operator !=(Point firstPoint, Point secondPoint) => !(firstPoint == secondPoint);

        public override bool Equals(object otherPoint)
        {
            Point tempPoint = otherPoint as Point;
            if (tempPoint is null || otherPoint is null) return false;
            return X == tempPoint.X && Y == tempPoint.Y;
        }

        public override int GetHashCode() => X ^ Y;

        public override string ToString() => $"[{X},{Y}]";

        /// <summary>
        /// Checks possibility to move.
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        /// <returns>False if the new coordinates are outside of grid's boudaries</returns>
    }
}
