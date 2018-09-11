using System;
using System.Collections.Generic;

namespace SimpleGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void UseGenericList()
        {
            Console.WriteLine("***** Fun with Generics *****\n");
            //This List<> can hold only Person objects
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);

            //This List<> can hold only integers
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(20);
            int sum = moreInts[0] + moreInts[1];
        }
    }
}
