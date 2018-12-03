using System;

namespace PakingUnpaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Sphere() { Name = "Сфера1" };
            s1.Draw();

            Sphere s2 = new Sphere() { Name = "Фигура2" };
            s2.Draw();

            Console.WriteLine(Shape.count);
            Console.WriteLine(Sphere.count);
        }
    }
    class Point
    {
        private static string name;

        public string Name
        {
            set { name = value; } 
            get { return name; }
        }
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public override string ToString()
        {
            return $"Name = {Name}; X = {X}, Y = {Y}";
        }
    }

    class Shape
    {
        public static int count;
        public string Name { set; get; } = "Shape";
        public Shape() => count++;
        static Shape() => count = 1; 
        public virtual void Draw()
        {
            Console.WriteLine($"Draw() не переопределен, всего фигур {count}");
        }
    }
    class Sphere : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Рисуем сферу c именем {Name} -- она круглая, всего фигур {count}");
        }
    }
}
