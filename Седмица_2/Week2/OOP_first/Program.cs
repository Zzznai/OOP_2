using System;

namespace OOP_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point(3, 4);
            Point secondPoint = new Point(0, 0);
            Console.WriteLine($"Distance between points: {firstPoint.Distance(secondPoint)}");
        }
    }


    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            private set { x = value; }
        }

        public int Y
        {
            get { return y; }
            private set { y = value; }
        }

        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distance(Point secondPoint)
        {
            return Math.Sqrt(Math.Pow(secondPoint.X - this.X, 2) + Math.Pow(secondPoint.Y - this.Y, 2));
        }
    }

}
