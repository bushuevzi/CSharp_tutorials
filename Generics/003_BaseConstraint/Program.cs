using System;

namespace _003_BaseConstraint
{
    class Base { }
    class Derived : Base { }

    class MyClass<T> where T : Base { }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass<Base> mc1 = new MyClass<Base>();
            MyClass<Derived> mc2 = new MyClass<Derived>();
        }
    }
}
