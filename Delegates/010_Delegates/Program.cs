using System;

namespace _010_Delegates
{
    delegate Delegate2 Delegate1();
    delegate void Delegate2();

    class Program
    {
        public static Delegate2 Method1()
        {
            return new Delegate2(Method2);
        }

        public static void Method2()
        {
            Console.WriteLine("Hello world!");
        }

        static void Main(string[] args)
        {
            Delegate1 delegate1 = new Delegate1(Method1);
            Delegate2 delegate2 = delegate1();

            delegate2();
        }
    }
}
