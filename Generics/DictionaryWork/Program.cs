using System;
using System.Collections.Generic;

namespace DictionaryWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(0, "Null");
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");

            Console.WriteLine(dictionary.ContainsValue("Null"));
            Console.WriteLine(dictionary.ContainsKey(0));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(dictionary[3]);
            Console.WriteLine(new string('-', 30));
            
            for(int i = 0; i < dictionary.Count; i++)
                Console.WriteLine(dictionary[i]);

            Console.WriteLine(new string('-', 30));

            foreach(var elem in dictionary)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
