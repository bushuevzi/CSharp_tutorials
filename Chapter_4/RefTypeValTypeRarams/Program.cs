using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeRarams
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person("Zakhar", 32);
            Console.WriteLine("=> Before changes");
            pers.Display();
            
            SendAPersonByValue(pers);
            Console.WriteLine("\n=> After changes");
            pers.Display();
        }

        static void SendAPersonByValue(Person p)
        {
            //Change the age of "p"
            p.personAge = 99;
            //caller not see this reassignment.
            p = new Person("Nikki", 66);
        }
    }

    class Person
    {
        public string personName;
        public int personAge;

        //Constractors
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }
        public void Display()
        {
            Console.WriteLine($"Name: {personName}, Age: {personAge}");
        }
    }
}
