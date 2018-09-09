using System;

namespace ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First look at Interfaces *****\n");

            //All of these classes support the Icloneable interface
            string myStr = "Hello";
            OperatingSystem unixOs = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();

            //Therefore, they can all passed into a method taking ICloeable
            CloneMe(myStr);
            CloneMe(unixOs);
            CloneMe(sqlCnn);
        }

        private static void CloneMe(ICloneable c)
        {
            //Clone whatever we gat and print out the name
            object theClone = c.Clone();
            Console.WriteLine($"Your clone is a: {theClone.GetType().Name}");
        }
    }
}
