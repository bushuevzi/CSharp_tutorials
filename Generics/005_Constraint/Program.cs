using System;

namespace _005_Constraint
{
    interface IInterface { }
    interface IInterface<U> : IInterface { }

    class Derived : IInterface, IInterface<object> { }
    class Derived2 : IInterface<object> { }

    class MyClass<T> where T : IInterface, IInterface<object> { }
    class MyClass2<T> where T : IInterface<object> { }

    class Program 
    {
        static void Main(string[] args)
        {
            MyClass<Derived> my1 = new MyClass<Derived>();
            MyClass2<Derived> my2 = new MyClass2<Derived>();
            MyClass<Derived2> my3 = new MyClass<Derived2>();
            MyClass2<Derived2> my4 = new MyClass2<Derived2>();
        }
    }
}
