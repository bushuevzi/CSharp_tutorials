using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
                textColor: ConsoleColor.DarkRed,
                backgroundColor: ConsoleColor.White);
        }

        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            //store old colors to restore after message os printed
            ConsoleColor oldTextCollor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            //Set new colors and print message
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            //Restore previous colors
            Console.ForegroundColor = oldTextCollor;
            Console.BackgroundColor = oldBackgroundColor;
        }
    }
}
