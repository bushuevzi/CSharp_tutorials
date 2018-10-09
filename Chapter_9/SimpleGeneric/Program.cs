using System;
using System.Collections.Generic;
using System.Collections;

namespace SimpleGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = { 10, 4, 2, 33, 93 };
            //Specify the placeholder to the generic Sort<>() method
            Array.Sort<int>(myInts);
            foreach(int i in myInts)
                Console.WriteLine(i);
        }

        static void InitialisationCollections()
        {
            //Init standard array
            int[] myArrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Init a generic List<> of ints
            List<int> myGenericList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Init an Array List with numerical data
            ArrayList myList = new ArrayList { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
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
