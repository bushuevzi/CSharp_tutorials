using System;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Anonymous Methods *****\n");
            int aboutToBlowCounter = 0;

            Car c1 = new Car("SlugBug", 100, 10);

            //Регистрируем обработчики событий как анонимные методы
            c1.AboutToBlow += delegate
            {
                aboutToBlowCounter++;
                Console.WriteLine("Eek! Going too fast!");
            };

            c1.AboutToBlow += delegate (string msg)
            {
                aboutToBlowCounter++;
                Console.WriteLine($"Message from Car: {msg}");
            };

            c1.Exploded += delegate (string msg)
            {
                Console.WriteLine($"Fatal Message from Car: {msg}");
            };

            //Этот код будет инициировать события
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.WriteLine($"AboutToBlow event was fired {aboutToBlowCounter} times");

            Console.ReadLine();
        }
    }
}
