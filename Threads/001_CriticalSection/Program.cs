using System;
using System.Threading;

namespace _001_CriticalSection
{
    class MyClass
    {
        object block = new object();

        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();

            lock (block)
            {
                for(int counter = 0; counter < 10; counter++)
                {
                    Console.WriteLine($"Поток № {hash}: шаг {counter}");
                    Thread.Sleep(100);
                }
                Console.WriteLine(new string('-', 20));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            MyClass instance = new MyClass();
            for(int i = 0; i <3; i++)
            {
                new Thread(instance.Method).Start();
            }

            Thread.Sleep(500); 
        }
    }
}
