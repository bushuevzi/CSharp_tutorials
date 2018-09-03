using System;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");
            //Make a Car object and set max speed
            Car myCar = new Car(80);
            //Set the current speed, and print it
            myCar.Speed = 50;
            Console.WriteLine($"My car is going {myCar.Speed} MPH");

            //Now make a MiniVan object
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine($"My van is going {myVan.Speed} MPH");
        }
    }
    //A simple base class
    class Car
    {
        //fields
        public readonly int maxSpeed;  //can be changed only in constructor
        private int currSpeed; 

        //Constructors
        public Car(int max)
        {
            maxSpeed = max;
        }
        public Car()
        {
            maxSpeed = 55;
        }
        
        //Properties
        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                    currSpeed = maxSpeed;
            }
        }
    }

    //MiniVan "is-a" Car
    class MiniVan : Car
    {

    }
}
