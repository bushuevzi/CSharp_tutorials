using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegateTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            //свяжем делегат с функцией-обработчиком
            ShowMessage method = Show;

            s.Move(25, method);
        }
        static void Show(string message)
        {
            Console.WriteLine(message); // здесь мы можем обработать сообщение как ходим и вывести его как хотим 
        }
    }

    public delegate void ShowMessage(string message);

    public class Student
    {
        public void Move(int distance, ShowMessage method)
        {
            for(int i=1; i <=distance; i++)
            {
                Thread.Sleep(1000);
                method(string.Format($"Идет перемещение ... пройдено километров: {i}"));
            }
        }
    }
}
