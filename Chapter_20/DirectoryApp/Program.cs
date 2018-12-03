using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with DirectoryInfo *****\n");
            FunWithDirectoryType();
        }

        static void ShowWindowsDirectoryInfo()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            Console.WriteLine("***** Directory Info *****");
            Console.WriteLine($"FullName: {dir.FullName}");
            Console.WriteLine($"Name: {dir.Name}");
            Console.WriteLine($"Parent: {dir.Parent}");
            Console.WriteLine($"Creation: {dir.CreationTime}");
            Console.WriteLine($"Attributes: {dir.Attributes}");
            Console.WriteLine($"Root: {0}", dir.Root);
            Console.WriteLine($"**************************\n");
        }

        static void DisplayImageFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
            //Get all files with a *.jpg extension
            FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

            //How many were found?
            Console.WriteLine($"Found {imageFiles.Length} *.jpg files\n");

            //Now print out info for each file
            foreach(FileInfo f in imageFiles)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine($"File name: {f.Name}");
                Console.WriteLine($"File size: {f.Length}");
                Console.WriteLine($"Creation: {f.CreationTime}");
                Console.WriteLine($"Attributes: {f.Attributes}");
                Console.WriteLine("*****************************\n");
            }
        }

        static void ModifyAppDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            //Create \MyFolder off appliction directory
            dir.CreateSubdirectory("MyFolder");
            //Создание ряда вложенных субдиректорий \MyFolder2\Data от директории dir
            DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"MyFolder2\Data");
            //сообщить текущий пусть до ..\MyFolder2\Data
            Console.WriteLine($"New Folder is: {myDataFolder}");
        }

        static void FunWithDirectoryType()
        {
            //перечислить все доступные на данной машине жесткие диски
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Here are you drives: ");
            foreach(string s in drives)
                Console.WriteLine($"--> {s}");

            //Удалить директории которые были созданны ранее
            Console.WriteLine("Press Enter to delete directories");
            Console.ReadLine();
            try
            {
                Directory.Delete(@"c:\MyFolder");
                //второй параметр используется для удаления поддерикторий (рекурсивно)
                Directory.Delete(@"c:\MyFolder2", true);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
