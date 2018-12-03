using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace AsyncCallbackDelegate
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        private static bool isDone = false;
        static void Main(string[] args)
        {
            Console.WriteLine("***** AsyncCallbackDelegate Example *****");
            Console.WriteLine($"Main() invoked on thread {Thread.CurrentThread.ManagedThreadId}");

            BinaryOp b = new BinaryOp(Add);
            //вызываем функцию обратной связи (AddComplete) через делегат AsyncCallback
            IAsyncResult ar = b.BeginInvoke(10, 10, new AsyncCallback(AddComplete), "Main() thanks you for adding these numbers");

            //Представим что остальная работа выполняется здесь
            while(!isDone)
            {
                Console.WriteLine("Working....");
                Thread.Sleep(1000);
            }
        }

        static int Add(int x, int y)
        {
            //Print out the ID of the executing thread
            Console.WriteLine($"Add() invoked on thread {Thread.CurrentThread.ManagedThreadId}");
            //pause to simulate a lengthy operation
            Thread.Sleep(5000);
            return x + y;
        }

        //Функция обратной связи (метод-обработчик) который сигнализирует о том что поток выполнен
        static void AddComplete(IAsyncResult iar)
        {
            Console.WriteLine($"AddComplete() invoked on thread {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Your addition is complete");

            //теперь получим результат
            AsyncResult ar = (AsyncResult)iar;
            BinaryOp b = (BinaryOp)ar.AsyncDelegate;
            Console.WriteLine($"10 + 10 is {b.EndInvoke(iar)}");

            //Получить информационный объект (строчку передаваемую четвертым объектом в BeginInvoke) и привести его к типу string
            string msg = (string)iar.AsyncState;
            Console.WriteLine(msg);
            isDone = true;
        }
    }
}
