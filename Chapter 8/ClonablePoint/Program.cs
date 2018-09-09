using System;

namespace ClonablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two references to same object
            Point p1 = new Point(50, 50);
            Point p2 = p1;
            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Point p3 = new Point(100, 100);
            Point p4 = (Point)p3.Clone();

            Console.WriteLine("Before modification:");
            Console.WriteLine($"p3: {p3}");
            Console.WriteLine($"p4: {p4}");

            p4.desc.PetName = "My new Point";
            p4.X = 9;
            Console.WriteLine("\nChanged p4.desc.PetName and p4.X");
            Console.WriteLine("After modification: ");
            Console.WriteLine($"p3: {p3}");
            Console.WriteLine($"p4: {p4}");
        }
    }
}
