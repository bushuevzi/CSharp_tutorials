using System;

namespace _012_Delegates
{
    delegate string MyDelegate();
    delegate MyDelegate Functional(MyDelegate myDelegate1, MyDelegate myDelegate2);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate delegate1 = () => "Hello ", delegate2 = () => "world!";

            Functional functional = (MyDelegate d1, MyDelegate d2) => () =>  d1() + d2();

            Console.WriteLine(functional(delegate1, delegate2)());
        }
    }
}
