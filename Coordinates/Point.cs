using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates
{
    public class Point
    {
        //counting Point instances
        public static int PointCount { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            PointCount++;
        }
        
        //get distance between 2 points
        public static int GetDistanceBetweenPoints(Point start, Point end)
        {
            int AC = end.X - start.X;
            int BC = end.Y - start.Y;
            return (int)Math.Sqrt(AC * AC + BC * BC);
        }

        //get distance beetwenn current point and any other point
        public int GetDistanceToPoint(Point point)
        {
            int AC = point.X - X;
            int BC = point.Y - Y;
            return (int)Math.Sqrt(AC * AC + BC * BC);
        }
    }
}
