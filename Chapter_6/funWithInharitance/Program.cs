using System;

namespace funWithInharitance
{
    class Program
    {
        static void Main(string[] args)
        {
            B objB = new B();
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("Конструктор базового класса");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("Конструктор производного класса");
        }
    }
}
