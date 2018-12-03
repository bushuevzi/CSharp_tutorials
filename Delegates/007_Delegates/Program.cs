using System;

namespace _007_Delegates
{
    public delegate void MyDelegate(ref int a, ref int b, out int c);

    class Program
    {
        static void Main(string[] args)
        {
            int summand1 = 1, summand2 = 2, sum;

            MyDelegate myDelegate = delegate (ref int a, ref int b, out int c) { a++; b++; c = a + b; };
            myDelegate(ref summand1, ref summand2, out sum);
            Console.WriteLine($"{summand1} + {summand2} = {sum}");
        }
    }
}
