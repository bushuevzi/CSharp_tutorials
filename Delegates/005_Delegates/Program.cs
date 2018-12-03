using System;

namespace _005_Delegates
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello wold"); };
            myDelegate();
        }
    }
}
