using System;
using System.Collections;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            UsePersonCollection();
        }

        static void SimpleBoxUnboxOperation()
        {
            //Make a ValueType (int) variable
            int myInt = 25;
            //Box the int into an object reference
            object boxedInt = myInt;
            //Unbox the reference back into a corresponding int
            int unboxedInt = (int)boxedInt;
        }

        static void WorkingWithArrayList()
        {
            //Value types are automatically boxed when passing to a member requstinan object
            //ArrayList работает с объектами находящимияся в управляемой куче, числовые литералы которые передаются аргументом
            //неявно преобразуются в object чтобы быть перенесенными из стека в кучу
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            //Unboxing occurs when an object is converted back to stack-based data
            int i = (int)myInts[0];
            //Now it is reboxed, as WriteLine() requires object types!
            Console.WriteLine($"Value of you int: {i}");
        }

        static void UsePersonCollection()
        {
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Hommer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            foreach(Person p in myPeople)
                Console.WriteLine(p);
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }

    public class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        //Cast for caller
        public Person GetPerson(int pos) => (Person)arPeople[pos];
        //Insert only Person objects
        public void AddPerson(Person p)
        { arPeople.Add(p); }

        public void ClearPeople()
        { arPeople.Clear(); }

        public int Count => arPeople.Count;

        //Foreach enumeration support
        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }
}
