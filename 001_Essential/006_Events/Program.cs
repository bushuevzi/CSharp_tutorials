using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Events
{
    public delegate void EventDelegate();
    
    public class MyClass
    {
        public event EventDelegate MyEvent = null;
        public void InvokeEvent()
        {
            MyEvent();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.MyEvent += Handler1;
            instance.MyEvent += Handler2;
            instance.MyEvent += delegate { Console.WriteLine("Анонимный метов 1."); };

            instance.InvokeEvent();
            Console.WriteLine(new string('-', 30));

            instance.MyEvent -= Handler2;
            instance.MyEvent -= delegate { Console.WriteLine("Анонимный метов 1."); };
            instance.InvokeEvent();
        }

        static private void Handler1()
        {
            Console.WriteLine("Handler1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Hander2");
        }
    }
}
