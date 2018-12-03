using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple I/ with the File Type *****\n");
            string[] myTasks =
            {
                "Fix bathroom sink", "Call Dave",
                "Call Mom and Dad", "Play Xbox One"};
            //записать все данные в файл на диске C
            File.WriteAllLines(@"c:\tasks.txt", myTasks);

            //прочитать все записанные данные обратно и вывести их на экран
            foreach(string task in File.ReadAllLines(@"c:\tasks.txt"))
            {
                Console.WriteLine($"TODO: {task}");
            }
        }
    }
}
