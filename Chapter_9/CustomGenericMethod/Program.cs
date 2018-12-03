using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Swap 2 ints
            int a = 10, b = 90;
            Console.WriteLine($"Before swap: {a}, {b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"After swap: {a}, {b}");
            Console.WriteLine();

            //Swap 2 strings
            string s1 = "Hello", s2 = "There";
            Console.WriteLine($"Before swap: {s1}, {s2}");
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"After swap: {s1}, {s2}");
            Console.WriteLine();

            //Компилятор сам поймет тип переменной 
            bool b1 = true, b2 = false;
            Console.WriteLine($"Before swap: {b1}, {b2}");
            Swap(ref b1, ref b2);
            Console.WriteLine($"After swap: {b1}, {b2}");
        }

        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine($"You send the Swap() method a {typeof(T)}");
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
