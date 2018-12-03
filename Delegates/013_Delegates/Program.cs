using System;

namespace _013_Delegates
{
    delegate void MyDelegate(int argument);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate my = null;

            my = (i) =>
            {
                i--;
                Console.WriteLine($"Begin {i}");
                if (i > 0) { my(i); };

                Console.WriteLine($"End {i}");
            };

            my(4);
        }
    }
}
