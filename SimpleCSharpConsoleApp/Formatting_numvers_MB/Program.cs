using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting_numbers_MB
{
    class Program
    {
        static void Main(string[] args)
        {
            DispayMessage();
        }

        private static void DispayMessage()
        {
            //Using string.Format() to format a string literal.
            string userMessage = string.Format("1000000 in hex is {0:x}", 1000000);

            //need PresentationFramework.dll 
            System.Windows.MessageBox.Show(userMessage);
        }
    }
}
