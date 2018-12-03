using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _001_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteSecond);
            thread.Start();

            while(true)
            {
                Console.WriteLine("Primary");
            }
        }

        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 10) + "Secondary");
            }
        }
    }

}
