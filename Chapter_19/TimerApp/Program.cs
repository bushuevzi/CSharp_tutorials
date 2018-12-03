using System;
using System.Threading;


namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with Timer type *****\n");
            //Создаем делегат для типа Timer
            TimerCallback timeCB = new TimerCallback(PrintTime);

            //Устанавливаем параметры
            Timer t = new Timer(
                timeCB,     // делегат TimerCallback
                null,       // информация для передачи в вызанный метод (null если инфо отсутствует)
                0,          //Период ожидания перед запуском (в миллисек)
                1000);      //Интервал между вызовами

            Console.WriteLine("Hit Enter key to terminate...");
            Console.ReadLine();
        }

        //метод-обработчик для делегата TimerCallback
        static void PrintTime(object state)
        {
            Console.WriteLine($"Time is: {DateTime.Now.ToLongTimeString()}");
        }
    }
}
