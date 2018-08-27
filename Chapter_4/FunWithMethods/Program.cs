using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            //value type
            int result = Add(x, y);
            Console.WriteLine(result);

            //output parameters, note- method return void
            Add(90, 90, out int result1);
            Console.WriteLine(result1);

            //Returning multiple output parameters.
            FillTheseValues(out int a, out string b, out bool c);
            Console.WriteLine($"a = {a};\nb = {b};\nc = {c}.");
        }

        //Returning multiple output parameters.
        private static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        // output parameters
        private static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        private static int Add(int x, int y)
        {
            int ans = x + y;
            //Caller will not see these changes as your are modifying a copy of the original data
            x = 100000;
            y = 4536676;
            return ans;
        }
    }
}
