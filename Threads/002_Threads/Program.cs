using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _002_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteSecond);
            thread.Start();

            WriteSecond();
        }

        static void WriteSecond()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Thread Id {Thread.CurrentThread.GetHashCode()}, counter = {counter}");
                counter++;
            }
        }
    }
}
