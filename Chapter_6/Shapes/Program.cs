using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };
            
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
        }
    }

    abstract class Shape
    {
        public string PetName { get; set; }

        public Shape(string name = "NoName")
        {
            PetName = name;
        }

        public abstract void Draw();
    }

    //Circle DOES NOT override Draw()
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Circle");
        }
    }

    //Hexagon DOES override Draw()
    class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon");
        }
    }
}
