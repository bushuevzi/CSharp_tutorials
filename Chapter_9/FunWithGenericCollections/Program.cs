using System;
using System.Collections.Generic;
using System.Collections;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
        }

        static void UseGenericList()
        {
            //Make a List of Person objects, fillid with
            //collection/object init syntax
            List<Person> people = new List<Person>()
            {
                new Person {FirstName="Homer", LastName="Simpson",Age=47},
                new Person {FirstName="Marge", LastName="Simpson",Age=45},
                new Person {FirstName="Lisa", LastName="Simpson", Age=9},
                new Person {FirstName="Bart", LastName="Simpson", Age=8},
            };

            //Print out numbers of items in List
            Console.WriteLine($"Items in List: {people.Count}");

            //Enumerate over list
            foreach (Person p in people)
                Console.WriteLine(p);

            //Insert a new person
            Console.WriteLine("\n->Insertring new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine($"Items in List: {people.Count}");

            //Copy data into a new array
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
                Console.WriteLine($"First Name: {p.FirstName}");
        }
    }
}
