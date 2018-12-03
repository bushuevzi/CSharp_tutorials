using System;

namespace _009_Delegate
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate;

            myDelegate = delegate { Console.WriteLine("Hello 1"); };
            myDelegate += () => { Console.WriteLine("Hello 2"); };
            myDelegate += () => Console.WriteLine("Hello 3");

            myDelegate();
        }
    }
}
