using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Essential
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate ReactionOnPush = null;
        public void EnemyPushMe()
        {
            ReactionOnPush();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.ReactionOnPush += handler1;
            myClass.ReactionOnPush += handler2;
            myClass.EnemyPushMe();
        }

        static private void handler1()
        {
            Console.WriteLine("Отклонился в напралении толчка");
        }

        static private void handler2()
        {
            Console.WriteLine("Поймал равновесие");
        }
    }
}
