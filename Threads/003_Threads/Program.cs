using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _003_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            Console.WriteLine($"ID потока {primaryThread.Name}: {primaryThread.GetHashCode()}");

            Thread secondaryThread = new Thread(WriteSecond);
            secondaryThread.Start();
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(primaryThread.Name + " " + counter);
                Thread.Sleep(1000);
            }
        }

        static void WriteSecond()
        {
            Thread thread = Thread.CurrentThread;

            thread.Name = "Secondary";

            Console.WriteLine($"ID потока {thread.Name}: {thread.GetHashCode()}");

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(new string(' ', 15) + thread.Name + " " + counter);
                Thread.Sleep(1000);
            }
        }
    }
}
