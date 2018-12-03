using System;

namespace CarDelegateMethodGroupConverion
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();

            //Register the simple method name
            c1.RegisterWithCarEngine(CallMeHere);

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            //Unregistre the simple method name
            c1.UnRegisterWithCarEngine(CallMeHere);

            //No more nitificatios!
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.ReadLine();
        }

        static void CallMeHere(string msg)
        {
            Console.WriteLine($"=> Message from Car: {msg}");
        }
    }
}
