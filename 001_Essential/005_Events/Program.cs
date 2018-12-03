using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Events
{
    public delegate void EventDelegate();

    interface IInterface
    {
        event EventDelegate MyEvent;
        void InvokeEvent();
    }

    public class BaseClass : IInterface
    {
        public virtual event EventDelegate MyEvent = null;
        public virtual void InvokeEvent()
        {
            MyEvent();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent = null;
        public override void InvokeEvent()
        {
            MyEvent();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.MyEvent += Handler1;
            instance.MyEvent += Handler2;
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 30));

            instance.MyEvent -= Handler2;
            instance.InvokeEvent();
        }

        static private void Handler1()
        {
            Console.WriteLine("Handler1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Handler2");
        }
    }
}
