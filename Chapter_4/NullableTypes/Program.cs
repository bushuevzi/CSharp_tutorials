using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun whith Nullable Data *****\n");
            DatabaseReder dr = new DatabaseReder();

            //Get int from "database"
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
                Console.WriteLine($"Value of 'i' is: {i.Value}");
            else
                Console.WriteLine("Value of 'i' is undefined.");

            //Get bool from "database"
            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
                Console.WriteLine($"Value of 'b' is: {b.Value}");
            else
                Console.WriteLine("Value of 'b' is undefined.");
        }
    }

    class DatabaseReder
    {
        //Nullable data field
        public int? numericValue = null;
        public bool? boolValue = true;

        //Note the nullable return type
        public int? GetIntFromDatabase()
        { return numericValue; }

        //Note the nullable return true
        public bool? GetBoolFromDatabase()
        { return boolValue; }
    }
}
