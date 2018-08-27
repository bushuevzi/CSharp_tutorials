using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp_3_FunWithImplicitVars
{
    class Program
    {
        static void Main(string[] args)
        {
            //DeclareImplicitVars();
            LinqQueryOverInts();
        }

        private static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            //LINQ query!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach (var i in subset)
                Console.Write($"{i} ");
            Console.WriteLine();

            //what type is subset?
            Console.WriteLine($"subset is a: {subset.GetType().Name}");
            Console.WriteLine($"subset is define in: {subset.GetType().Namespace}");
        }

        private static void DeclareImplicitVars()
        {
            //неявная типизация локальных переменных
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            Console.WriteLine($"myInt is a: {myInt.GetType().Name}");
            Console.WriteLine($"myBool is a: {myBool.GetType().Name}");
            Console.WriteLine($"myString is a: {myString.GetType().Name}");
        }
    }
}
