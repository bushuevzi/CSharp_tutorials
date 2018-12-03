using System;
using System.Threading;

namespace AddWithThreads
{
    class Program
    {
        private static AutoResetEvent waitHandle = new AutoResetEvent(false); // пункт 1
        static void Main(string[] args)
        {
            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine($"ID of thread in Main(): {Thread.CurrentThread.ManagedThreadId}");

            //Make an AddParams object to pass to the secondary thread
            AddParams ap = new AddParams(10, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);

            // автоматическое ожидаение завершение других потоков.
            waitHandle.WaitOne();
            Console.WriteLine("Other thread is done!");

        }
        
        static void Add(object data)
        {
            if(data is AddParams)
            {
                Console.WriteLine($"ID of thread in Add(): {Thread.CurrentThread.ManagedThreadId}");

                AddParams ap = (AddParams)data;
                Console.WriteLine($"{ap.a} + {ap.b} is {ap.a + ap.b}");

                //Сказать другому потоку что мы закончили
                waitHandle.Set();
            }
        }
    }

    class AddParams
    {
        public int a, b;

        public AddParams(int numb1, int numb2)
        {
            a = numb1;
            b = numb2;
        }
    }
}
