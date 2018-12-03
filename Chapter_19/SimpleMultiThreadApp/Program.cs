using System;
using System.Threading;
using System.Windows.Forms;

namespace SimpleMultiThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Amazing Thread App *****\n");
            Console.Write($"Do you want [1] or [2] threads? ");
            string threadCount = Console.ReadLine();

            //Name the current thread
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            //Display Thread info
            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

            //Создание исполняющего класса (пункт 1 из чек листа)
            Printer p = new Printer();

            switch(threadCount)
            {
                case "2":
                    //Now make the thread
                    Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "Secondary";
                    backgroundThread.Start();
                    break;

                case "1":
                    p.PrintNumbers(); 
                    break;
                default:
                    Console.WriteLine("I don't know what you want ... you get 1 thread");
                    goto case "1";
            }
            //Do some additional work
            MessageBox.Show("I'm Busy!", "Work on main thread...");
            Console.ReadLine();
        }
    }

    public class Printer
    {
        public void PrintNumbers()
        {
            //Вывести информацию о потоке
            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

            //Печать чисел
            Console.Write("You numbers: ");
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{i}, ");
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
}
