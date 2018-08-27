using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowEnvironmentDetails();
            
        }

        private static void ShowEnvironmentDetails()
        {
            //print drives and other interesting details
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET version: {0}", Environment.Version);
        }
    }
}
