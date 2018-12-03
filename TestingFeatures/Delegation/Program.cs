using System;

namespace Delegation
{
    class A
    {
        public string DoSomething(string s)
        {
            return s + "iiiiiiiii";
        }
    }

    class B
    {
        public string DoSomething(string s)
        {
            return (new A().DoSomething(s));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new B().DoSomething("L"));

        }
    }
}
