using System;

namespace StructInheritance
{
    enum MyEnum: byte
    {
        zero = 0,
        one = 1,
        two = 2,
        three = 3,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Array array = Enum.GetValues(typeof(MyEnum));
            foreach(MyEnum i in array)
                Console.WriteLine(i);
        }
    }
}
