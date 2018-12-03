using System;
using System.Collections.Generic;

namespace SimpleGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDictionary();
        }

        static void UseGenericList()
        {
            //Make a List of Person objects, filled with
            //collection/object init syntax
            List<Person> people = new List<Person>()
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age=47},
                new Person {FirstName = "Marge", LastName = "Simpson", Age=45},
                new Person {FirstName = "Lisa", LastName = "Simpson", Age=9},
                new Person {FirstName = "Bart", LastName = "Simpson", Age=8},
            };

            //Print out # of items in List
            Console.WriteLine($"Items in list: {people.Count}");

            //Enumerate over list
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            //insert a new person
            Console.WriteLine("\n->Inserting new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine($"Items in list: {people.Count}");

            //Copy data into a new array
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
                Console.WriteLine($"First Names: {p.FirstName}");
        }

        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person(firstName: "Marge", lastName: "Simpson", age: 45));
            stackOfPeople.Push(new Person("Lisa", "Simpson", 9));

            //Now look at the top item, pop it, and look again
            Console.WriteLine($"First person is: {stackOfPeople.Peek()}");
            Console.WriteLine($"Popped of {stackOfPeople.Pop()}");
            Console.WriteLine($"\nFirst person is: {stackOfPeople.Peek()}");
            Console.WriteLine($"Popped of {stackOfPeople.Pop()}");
            Console.WriteLine($"\nFirst person is: {stackOfPeople.Peek()}");
            Console.WriteLine($"Popped of {stackOfPeople.Pop()}");

            try
            {
                Console.WriteLine($"\n\nFirst person is: {stackOfPeople.Peek()}");
                Console.WriteLine($"Popped of {stackOfPeople.Pop()}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"\nError! {ex.Message}"); 
            }
        }

        static void GetCoffe(Person p)
        {
            Console.WriteLine($"{p.FirstName} got coffee!");
        }
        static void UseGenericQueue()
        {
            // Make a Q with three pople
            Queue<Person> personQ = new Queue<Person>();
            personQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            personQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            personQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            //Peek at first person in Q
            Console.WriteLine($"{personQ.Peek().FirstName} is first in line!");

            //Remove each person from Q
            GetCoffe(personQ.Dequeue());
            GetCoffe(personQ.Dequeue());
            GetCoffe(personQ.Dequeue());
            //Try to de-Q again?
            try
            {
                GetCoffe(personQ.Dequeue());
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine($"Error! {e.Message}");
            }
        }

        static void UseSortedSet()
        {
            //Make some people with different ages.
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age=47},
                new Person {FirstName = "Marge", LastName = "Simpson", Age=45},
                new Person {FirstName = "Lisa", LastName = "Simpson", Age= 9},
                new Person {FirstName = "Bart", LastName = "Simpson", Age = 8}
            };

            //Note the items are sorted by age!
            foreach (Person p in setOfPeople)
                Console.WriteLine(p);
            Console.WriteLine();

            //Add a few new people, with various ages 
            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
            
            //Still sorted by age!
            foreach (Person p in setOfPeople)
                Console.WriteLine(p);

        }

        static void UseDictionary()
        {
            //Populate using Add() method
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleA.Add("Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleA.Add("Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            //Get Homer
            Person homer = peopleA["Homer"];
            Console.WriteLine(homer);

            //Populate using initialization syntax 
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                {"Homer", new Person {FirstName = "Homer", LastName = "Simpson", Age = 47}},
                {"Marge", new Person {FirstName = "Marge", LastName = "Simpson", Age = 45} },
                {"Lisa", new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9} }
            };
            //Get Lisa 
            Person lisa = peopleB["Lisa"];
            Console.WriteLine(lisa);

            //Populate with dictionary initialization syntax
            Dictionary<string, Person> peopleC = new Dictionary<string, Person>()
            {
                ["Homer"] = new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                ["Marge"] = new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                ["Lisa"] = new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }
            };
            //Get Marge
            Person marge = peopleC["Marge"];
            Console.WriteLine(marge);
        }
    }
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            if(firstPerson?.Age > secondPerson?.Age)
            {
                return 1;
            }
            if (firstPerson?.Age < secondPerson?.Age)
            {
                return -1;
            }
            return 0;
        }
    }
}
