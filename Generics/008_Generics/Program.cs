using System;

namespace _008_Generics
{
    public abstract class Shape { }
    public class Circle : Shape { }

    public interface IConteiner<in T>
    {
        T Figure { set; }
    }
    public class Container<T> : IConteiner<T>
    {
        private T figure;
        public T Figure
        {
            set { figure = value; }
        }

        public Container(T figure)
        {
            this.figure = figure;
        }

        public override string ToString()
        {
            return figure.GetType().ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle();
            IConteiner<Circle> conteiner = new Container<Shape>(shape);
            Console.WriteLine(conteiner.ToString());
        }
    }
}
