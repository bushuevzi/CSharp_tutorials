using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Primary Thread stats *****\n");

            //Obtain and name the current thread
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";

            //show datails of hosting AppDomain/Context
            Console.WriteLine($"Name of current AppDomain: {Thread.GetDomain().FriendlyName}");
            Console.WriteLine($"ID of current Context: {Thread.CurrentContext.ContextID}");

            //Print out some stats about this thread
            Console.WriteLine($"Thread Name: {primaryThread.Name}");
            Console.WriteLine($"Has the thread started: {primaryThread.IsAlive}");
            Console.WriteLine($"Priority Level: {primaryThread.Priority}");
            Console.WriteLine($"Thread State: {primaryThread.ThreadState}");

            Console.ReadLine();
        }
    }
}
