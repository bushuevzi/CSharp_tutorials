using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassExample
{
    class Car
    {
        //The 'state' of the Car
        private string petName;
        private int currSpeed;

        //The functionality of the Car
        //Using the expression-bodied member syntax 
        public void PrintState() => Console.WriteLine($"{petName} is going {currSpeed} MPH.");

        public void SpeedUp(int delta)
            => currSpeed += delta;

        // A custom default constructor
        public Car()
        {
            petName = "Cuck";
            currSpeed = 10;
        }
        //Here, currSpeed will receive the default of an int (zero)
        public Car(string pn) => petName = pn;

        //Let caller set the full state of the Car
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }
    }
}
