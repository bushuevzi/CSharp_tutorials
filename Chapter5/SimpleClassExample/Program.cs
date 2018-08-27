using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            //Invoking the default constructor
            Car chuck = new Car();
            //prints "Chuck is going 10MPH"
            chuck.PrintState();

            //Make a Car called Mary going 0MPH
            Car mary = new Car("Mary");
            mary.PrintState();

            //Make a Car called Daisy ging 75MPH
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

        }
    }
}
