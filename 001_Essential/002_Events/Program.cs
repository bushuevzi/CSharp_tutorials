using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        EventDelegate myEvent = null;

        public event EventDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.MyEvent += Handler1;
            myClass.MyEvent += Handler2;
            myClass.InvokeEvent();
            Console.WriteLine(new string('-', 30));
            myClass.MyEvent -= Handler1;
            myClass.InvokeEvent();
        }

        static private void Handler1()
        {
            Console.WriteLine("Handler 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Handler 2");
        }
    }
}
