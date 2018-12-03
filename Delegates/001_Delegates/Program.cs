using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Delegates
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Строку вывел метод сообщенный с делегатом");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);

            myDelegate();
        }
    }
}
