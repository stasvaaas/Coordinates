namespace Coordinates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point t = new Point(345, 100);
            Point a = new Point(112, 30);
            Point f = new Point(330, 240);
            Console.WriteLine(t.GetDistanceToPoint(a));
            Console.WriteLine(Point.GetDistanceBetweenPoints(a, f));
            Console.WriteLine(Point.GetDistanceBetweenPoints(t, f));
            Console.WriteLine(Point.PointCount);
        }
    }
}