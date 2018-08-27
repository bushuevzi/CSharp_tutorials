using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChP_3_FunWithStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringInterpolation();
        }

        private static void StringInterpolation()
        {
            int age = 4;
            string name = "Soren";
            string greating = string.Format("Hello {0} you are {1} years old.", name, age);
            Console.WriteLine(greating);

            //Using string interpolation
            string greating2 = $"Hello {name.ToUpper()} you are {age+100} years old.";
            Console.WriteLine(greating2);
        }
    }
}
