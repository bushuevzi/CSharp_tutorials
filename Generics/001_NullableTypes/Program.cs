using System;

namespace _001_NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b;
            b = a ?? 10;
            Console.WriteLine(b);
        }
    }
}
