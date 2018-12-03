using System;

namespace Extension
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Тестовая строка";
            text.ExtensionMethod();
        }
    }
}
