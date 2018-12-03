using System;
using System.Threading;

namespace _003_CriticalSection
{
    class Program
    {
        static object locker = new object();

        static void WriteSecond()
        {
            for (int i = 0; i < 20; i++)
            {
                lock(locker)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string(' ', 20) + "Secondary");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 45);
            Thread thread = new Thread(WriteSecond);
            thread.Start();

            for (int i = 0; i < 20; i++)
            {
                lock (locker)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Primary");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }
        }
    }
}
