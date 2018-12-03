using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Events
{
    public delegate void EventDelegate();

    interface IInharitance
    {
        event EventDelegate MyEvent;
    }

    public class BaseClass: IInharitance
    {
        EventDelegate myEvent = null;
        public virtual event EventDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent();
        }
    }
    
    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent
        {
            add
            {
                base.MyEvent += value;
                Console.WriteLine($"К событию базового класса был прикреплен обработчик - {value.Method.Name}");
            }
            remove
            {
                base.MyEvent -= value;
                Console.WriteLine($"От события базового класса был откреплен обработчик - {value.Method.Name}");
            }
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

            Console.WriteLine(new string('-', 40));
            instance.MyEvent -= Handler2;
            instance.InvokeEvent();

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
