using System;
using System.Threading;

namespace MultiThreadedPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Synchronizing Threads *****\n");
            Console.WriteLine($"Main() thread started. ThreadID = {Thread.CurrentThread.ManagedThreadId}");
            Printer p = new Printer();

            WaitCallback workItem = new WaitCallback(PrintTheNumbers);

            //поставить в очередь метод десять раз
            for (int i = 0; i < 10; i++)
                ThreadPool.QueueUserWorkItem(workItem, p);

            Console.WriteLine("All tasks queued");
            Console.ReadLine();
        }

        static void PrintTheNumbers(object state)
        {
            Printer task = (Printer)state;
            task.PrintNumbers();
        }
    }

    public class Printer
    {
        //маркер блокировки
        private object threadLock = new object();

        public void PrintNumbers()
        {
            //Использовать маркер блокировки !!! Весь блок внутри него не будет прерван другими потоками!!!
            lock(threadLock)
            {
                //Вывести информацию о потоке
                Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

                //Печать чисел
                Console.Write("You numbers: ");
                for(int i = 0; i < 10; i++)
                {
                    //отправляем поток спать на случайно сгенерированнаое время
                    Random r = new Random();
                    Thread.Sleep(100 * r.Next(5));
                    Console.Write($"{i}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
