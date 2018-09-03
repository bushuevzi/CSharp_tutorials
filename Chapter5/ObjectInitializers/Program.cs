using System;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");
            //Calling a custom constructor with init syntax
            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();
        }
    }

    enum PointColor
    { LightBlue, BloodRed, Gold}

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }
        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }

        public Point()
            :this(PointColor.BloodRed) { }

        public void DisplayStats()
        {
            Console.WriteLine($"[{X}, {Y}]");
            Console.WriteLine($"Point is {Color}");
        }
    }
}
