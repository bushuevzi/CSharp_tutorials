using System;

namespace _001_Constraint
{
    class MyClass1<T> where T: class
    {
        public T variable;
    }

    class MyClass2<T> where T:struct
    {
        public T variable;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass1<string> instance1 = new MyClass1<string>();

            MyClass2<int> instance2 = new MyClass2<int>();
        }
    }
}
