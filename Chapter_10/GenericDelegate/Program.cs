using System;

namespace GenericDelegate
{
    class Program
    {
        //This generic delegate can represent any method
        //returning void and taking a single parameter of type T
        public delegate void MyGenericDelegate<T>(T arg);

        static void Main(string[] args)
        {
            Console.WriteLine("***** Generic Delegates *****\n");

            //Register targets.
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            strTarget("Some string data");

            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(9);

            Console.ReadLine();
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine($"arg in Uppercase is: {arg.ToUpper()}");
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine($"++arg is: {++arg}");
        }
    }
}
