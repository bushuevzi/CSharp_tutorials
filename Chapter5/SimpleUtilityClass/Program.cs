using System;
using static System.DateTime;

namespace SimpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();
        }
    }

    //Static classes can only
    //contain static members!
    static class TimeUtilClass
    {
        public static void PrintTime() => Console.WriteLine(Now.ToShortTimeString());
        public static void PrintDate() => Console.WriteLine(Today.ToShortDateString());
    }
}
