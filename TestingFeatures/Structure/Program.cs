using System;

namespace Structure
{
    struct MyStruct
    {
        public int field;

        static MyStruct()
        {
            Console.WriteLine("static ctor");
        }

        public MyStruct(int value)
        {
            Console.WriteLine("cust ctor");
            field = value;
        }

        public void Show()
        {
            Console.WriteLine(field);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyStruct instance = new MyStruct();
            Console.WriteLine(instance.field);
        }
    }
}
