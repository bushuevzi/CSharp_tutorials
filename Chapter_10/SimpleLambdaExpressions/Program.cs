using System;
using System.Collections.Generic;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****\n");
            TraditionalDelegateSyntax();

            Console.ReadLine();
        }

        static void TraditionalDelegateSyntax()
        {
            //Make a list of integers
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Использование лямбда-функции
            List<int> evenNumbers = list.FindAll((int i) =>
            {
                Console.WriteLine($"value of i is currently {i}");
                bool isEven = ((i % 2) == 0);
                return isEven;
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write($"{evenNumber}\t");
            }
            Console.WriteLine();
        }
    }
}
