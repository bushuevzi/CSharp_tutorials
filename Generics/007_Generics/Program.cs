using System;

namespace _007_Generics
{
    public abstract class Shape { }
    public class Circle : Shape { }

    public interface IContainer<out T>
    {
        T Figure { get; }
    }

    public class Container<T> : IContainer<T>
    {
        private T figure;
        public T Figure
        {
            get { return figure; }
        }

        public Container(T figure)
        {
            this.figure = figure;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            IContainer<Shape> container = new Container<Shape>(circle);
            Console.WriteLine(container.Figure.ToString());
        }
    }
}
