using System;

namespace _011_Delegates
{
    delegate string Delegate1();
    delegate string Delegate2();
    delegate string Delegate3();
    delegate Delegate3 Functional(Delegate1 delegate1, Delegate2 delegate2);

    class Program
    {
        public static Delegate3 MethodF(Delegate1 delegate1, Delegate2 delegate2)
        {
            return delegate { return delegate1() + delegate2(); };
        }

        public static string Method1() { return "Hello "; }
        public static string Method2() { return "wordl!"; }

        static void Main(string[] args)
        {
            Functional functional = MethodF;

            Delegate3 delegate3 = functional(new Delegate1(Method1), new Delegate2(Method2));

            Console.WriteLine(delegate3());
        }
    }
}
