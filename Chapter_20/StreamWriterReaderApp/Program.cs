using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fin with StreamWriter / StreamReader *****\n");

            //Get a StreamWriter and write string data
            using (StreamWriter writer = File.CreateText("reminders.txt"))
            {
                writer.WriteLine("Don't forget Mother's Day this year...");
                writer.WriteLine("Don't forget Father's Day this year...");
                writer.WriteLine("Don't forget these numbers:");
                for (int i = 0; i < 10; i++)
                    writer.Write(i + " ");

                //Insert a new Line
                writer.Write(writer.NewLine);
            }
            Console.WriteLine("Chreated file and wrote some thoughts...");

            //Now read data from file
            Console.WriteLine("Here are you thoughts:\n");
            using (StreamReader sr = File.OpenText("reminders.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine())!=null)
                    Console.WriteLine(input);
            }
        }
    }
}
