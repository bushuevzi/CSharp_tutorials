using System;

namespace _006_Delegates
{
    public delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            int summand1 = 1, summand2 = 2, sum = 0;
            MyDelegate myDelegate = delegate (int a, int b) { return a + b; };
            sum = myDelegate(summand1, summand2);
            Console.WriteLine($"{summand1} + {summand2} = {sum}");
        }
    }
}
