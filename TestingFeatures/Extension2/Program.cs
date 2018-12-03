using System;

namespace Extension2
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value1, string value2)
        {
            Console.WriteLine(value1 + value2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello ";
            test.ExtensionMethod("world!!!");
        }
    }
}
