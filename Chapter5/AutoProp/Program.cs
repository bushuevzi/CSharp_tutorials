using System;

namespace AutoProp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Place a car into the Garage
            Console.WriteLine("***** Fun with Automatic Properties *****\n");

            //Make a car
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            c.DisplayStats();

            //Put car in the Garage
            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine($"Number of Cars in garage: {g.NumberOfCars}");
            Console.WriteLine($"Your car is named: {g.MyAuto.PetName}"); // показывает что машина в гараже
        }
    }

    class Car
    {
        //Automatic properties! No need to define baking fields!
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public void DisplayStats()
        {
            Console.WriteLine($"Car Name: {PetName}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Color: {Color}");
        }
    }

    class Garage
    {
        // The hidden int backing field is set to zero!
        public int NumberOfCars { get; set; }

        //The hidden Car baking field is set to null!
        public Car MyAuto { get; set; }

        //Must use constructors to override default
        //values assigned to hiden backing fields/
        public Garage()
        {
            MyAuto = new Car();
            NumberOfCars = 1;
        }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
