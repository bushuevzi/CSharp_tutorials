using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DriveInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with DriveInfo *****\n");

            //Get info regarding all drives
            DriveInfo[] myDrives = DriveInfo.GetDrives();
            //Now print frive stats
            foreach(DriveInfo d in myDrives)
            {
                Console.WriteLine($"Name: {d.Name}");
                Console.WriteLine($"Type: {d.DriveType}");
                //проверить смонтирован ли диск
                if(d.IsReady)
                {
                    Console.WriteLine($"Free space: {d.TotalFreeSpace}");
                    Console.WriteLine($"Format: {d.DriveFormat}");
                    Console.WriteLine($"Label: {d.VolumeLabel}");
                }
                Console.WriteLine();
            }
        }
    }
}
