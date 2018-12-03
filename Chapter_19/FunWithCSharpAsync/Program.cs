using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithCSharpAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("***** Fun With Async *****");
            string message = await DoWorkAsync();
            Console.WriteLine(message);
            Console.WriteLine("Completed");
            Console.ReadLine();
        }

        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(()=> {
                Thread.Sleep(5_000);
                return "Done with work!";
            });
        }
    }
}
