using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //для вызова Thread.Sleep()

namespace AsyncDelegate
{
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Async Delegate Incovation *****");
            //print out the ID of the executing thread
            Console.WriteLine($"Main() invoked on thread {Thread.CurrentThread.ManagedThreadId}");

            //Invoke Add() on a secondary thread
            BinaryOp b = new BinaryOp(Add);
            IAsyncResult ar = b.BeginInvoke(10, 10, null, null);
            
            //Do other work on primary thread...
            while(!ar.IsCompleted)
            {
                Console.WriteLine($"Doing more work in Main()! #");
                Thread.Sleep(1000);
            }
            
            //Obtain the result of the Add()
            //method when ready
            int answer = b.EndInvoke(ar);
            Console.WriteLine($"10 + 10 is {answer}");
        }

        static int Add(int x, int y)
        {
            //Print out the ID of the executing thread
            Console.WriteLine($"Add() invoked on thread {Thread.CurrentThread.ManagedThreadId}");
            //pause to simulate a lengthy operation
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
