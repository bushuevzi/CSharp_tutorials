using System;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");

            //Use the Action<> delegate to point to DisplayMessage.
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);


            //Использование Func<> 
            Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine($"40 + 40 = {result}");

            Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);
            string sum = funcTarget2(90, 300);
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        //This is a target for the Action<> delegate
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            //Set color of console text
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for(int i =0; i < printCount; i++)
                Console.WriteLine(msg);

            //Restore color
            Console.ForegroundColor = previous;
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
