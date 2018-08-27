using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutePatternMatchingSwitch();
        }

        private static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
            Console.Write("Please choose an option: ");
            string userChoice = Console.ReadLine();
            object choice; //неопределенный тип

            switch(userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5M;
                    break;
                default:
                    choice = 5;
                    break;
            }

            switch (choice)
            {
                case int i:
                    Console.WriteLine($"Your choice is an integer {i}.");
                    break;
                case string s:
                    Console.WriteLine($"Your choice is an string {s}.");
                    break;
                case decimal d:
                    Console.WriteLine($"Your choice is a decimal {d}.");
                    break;
                default:
                    Console.WriteLine("Your choice is something else.");
                    break;
            }
        }
    }
}
