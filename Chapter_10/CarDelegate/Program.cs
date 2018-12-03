using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //First, make a Car object
            Car c1 = new Car("SlugBug", 100, 10);

            //Теперь говорим машине какой метод вызвать
            //когда машина посылает нам сообщение
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            //регистрация множественных целей для уведомления
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));

            //Speed up (this will trigger the events).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.ReadLine();
        }
        //теперь  мы имеем два метода которые будут вызваны из класса Car когда мы отправим сообщение (уведомление)
        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine($"=> {msg.ToUpper()}");
        }

        //Это цель для входящих сообщений 
        private static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine($"=> {msg}");
            Console.WriteLine("*************************************\n");
        }
    }
}
