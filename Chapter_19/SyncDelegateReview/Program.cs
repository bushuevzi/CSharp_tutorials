using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncDelegateReview
{
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Synch Delegate Review *****");

            //Print out the ID of the executing thread
            Console.WriteLine($"Main() invoked on thread {Thread.CurrentThread.ManagedThreadId}");

            //Invoke Add() in synchtonous manner
            BinaryOp b = new BinaryOp(Add);

            //Coul also write b.Invoke(10,10);
            int answer = b(10, 10);

            //These lines will not execute until
            //The Add() method has completed
            Console.WriteLine("Doing more work in Main()!");
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
