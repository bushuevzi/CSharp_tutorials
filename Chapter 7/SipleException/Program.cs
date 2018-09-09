using System;

namespace SipleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            //speed up past the car's max speed to trigger the exception
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine($"Method: {e.TargetSite}");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Source: {e.Source}");
            }
            finally
            {
                //это будет вызываться всегда. есть исключения ли нет
                myCar.CrankTunes(false);
            }
        }
    }

    class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on? "Jamming..." : "Quiet time...");
        }
    }

    class Car
    {
        public const int MaxSpeed = 100;

        //properties
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        //тачка рабочая?
        private bool carIsDead;

        // A car has-a radio 
        private Radio theMusicBox = new Radio();

        //Constructors
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            //Delegate request to inner object
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if(carIsDead)
                Console.WriteLine($"{PetName} is out of order...");
            else
            {
                CurrentSpeed += delta;
                if(CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;
                    //Use the "throw" keyword to raise an exception
                    throw new Exception($"{PetName} has overhated");
                }
                else
                    Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}
