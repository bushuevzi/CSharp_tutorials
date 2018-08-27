using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitSeparators();
        }

        private static void DigitSeparators()
        {
            Console.WriteLine("=> Use Digit Separators:");
            Console.Write("Integer: ");
            Console.WriteLine(123_456);
            Console.Write("Long: ");
            Console.WriteLine(123_456_789L);
            Console.Write("Float: ");
            Console.WriteLine(123_456.1234F);
            Console.Write("Double: ");
            Console.WriteLine(123_456.12);
            Console.Write("Desimal: ");
            Console.WriteLine(123_456.12M);
        }
    }
}
