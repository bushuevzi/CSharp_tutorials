using System;

namespace _0001_ExDelegate
{
    delegate void MyDelegate();

    public class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass inst = new MyClass();
            MyDelegate instDelegate = inst.Method1;
            instDelegate += inst.Method2;

            instDelegate();

        }
    }
}
