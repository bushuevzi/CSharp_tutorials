using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var samples = FillThiseValues();
            Console.WriteLine($"a = {samples.a}");
            Console.WriteLine($"b = {samples.b}");
            Console.WriteLine($"c = {samples.c}");
        }

        private static (int a, string b, bool c) FillThiseValues()
        {
            return (9, "Enjoy your string.", true);
        }
    }
}
