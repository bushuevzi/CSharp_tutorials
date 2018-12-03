using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList_ListGen
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add((object)2);
            int i1 = (int)arrayList[0];
            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine($"{(int)arrayList[i]} - {arrayList[i].GetType().ToString()}");

            Console.WriteLine(new string('-', 30));

            List<int> list = new List<int>();
            list.Add(3);
            list.Add(4);

            int i3 = list[0];
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
        }
    }
}
