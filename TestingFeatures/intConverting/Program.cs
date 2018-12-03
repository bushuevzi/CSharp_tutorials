using System;

namespace intConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int testNum = 123;
            Console.WriteLine(Convert.ToString(testNum, 2));
            Console.WriteLine(Convert.ToString(testNum, 8));
            Console.WriteLine(Convert.ToString(testNum, 10));
            Console.WriteLine(Convert.ToString(testNum, 16));
        }
    }
}
