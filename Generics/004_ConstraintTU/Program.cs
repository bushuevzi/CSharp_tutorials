using System;

namespace _004_ConstraintTU
{
    interface IInterface { }
    interface IInterface<U> { }

    class Derived : IInterface, IInterface<object> { }

    class MyClass<T> where T : IInterface, IInterface<object> { }
    class MyClass2<T> where T : IInterface { }
    class MyClass3<T> where T : IInterface<object> { }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass<Derived> my1 = new MyClass<Derived>();
            MyClass2<Derived> my2 = new MyClass2<Derived>();
            MyClass3<Derived> my3 = new MyClass3<Derived>();
        }
    }
}
