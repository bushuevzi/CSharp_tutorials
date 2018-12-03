using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegatesActionAndFunk
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Moving += Student_Moving;//4) подписываемся на Moving

            student.Move(7);
        }

        private static void Student_Moving(string message)    //3) создаем метод подписчик-обработчик события Moving
        {
            Console.WriteLine($"#### => {message} <= ####"); // Свойство Message будет содержать значение переданное в событие на строке 35 и обработанное конструктором на строке 45
        }
    }

    public class Student
    {
        public void Move(int distance)
        {
            for(int i = 1; i < distance; i++)
            {
                Thread.Sleep(1000);
                if (Moving != null)  // чтобы не вылетело ошибки если мы не подписались на Moving
                    // это выполнится если Moving реально ссылается на какойто метод
                    Moving(string.Format($"Идет перемещение ... пройдено километров: {i}"));// 2) вызываем событие Moving
            }
        }
        // 1) создаем событие Moving
        public event Action<string> Moving;
    }
}
