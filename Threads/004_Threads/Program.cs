using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _004_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart writeSecond = new ParameterizedThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start("Hello");

            Thread.Sleep(500);
        }

        static void WriteSecond(object argument)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(argument);
                Thread.Sleep(1000);
            }
        }
    }
}
