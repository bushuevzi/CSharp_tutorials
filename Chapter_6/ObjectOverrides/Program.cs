using System;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");

            Person p1 = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);

            Console.WriteLine($"p1.ToString() = {p1.ToString()}");
            Console.WriteLine($"p2.ToString() = {p2.ToString()}");

            //Test overriding Equals()
            Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");

            //Test hash codes
            Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");
            Console.WriteLine();

            //Change age of p2 and test again
            p2.Age = 45;
            Console.WriteLine($"p1.ToString() = {p1.ToString()}");
            Console.WriteLine($"p2.ToString() = {p2.ToString()}");
            Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");
            Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");
        }
    }

    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }


        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() { }

        //Overriding method System.Object.ToString() 
        public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
        public override int GetHashCode() => ToString().GetHashCode();
    }
}
