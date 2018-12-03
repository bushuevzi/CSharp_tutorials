using System;
using System.Threading;

namespace _006_Thread
{
    class Program
    {
        static void WriteSecond()
        {
            while(true)
            {
                Console.WriteLine(new string(' ', 15) + "Secondary");
                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteSecond);
            thread.Start(); 

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Primary");
                Thread.Sleep(500);

                thread.IsBackground = true;
            }
        }
    }
}
