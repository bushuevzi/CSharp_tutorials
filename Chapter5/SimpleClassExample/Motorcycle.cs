using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        private int driverIntesity;
        private string name;

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntesity; i++)
                Console.WriteLine("Yeeeeee Haaaaawww!");
        }

        //Constructor chaining
        public Motorcycle()
        {
            Console.WriteLine("In default ctor");
        }
        public Motorcycle(int intensity)
            : this(intensity, "")
        {
            Console.WriteLine("In ctor taking an int");
        }
        public Motorcycle(string name)
            : this(0, name)
        {
            Console.WriteLine("In ctor taking a string");
        }

        //This is the 'master' constructor that does all the real work
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In Master ctor");
            if (intensity > 10)
                intensity = 10;
            driverIntesity = intensity;
            this.name = name;
        }
    }
}
