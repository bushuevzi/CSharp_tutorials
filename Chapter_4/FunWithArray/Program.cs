using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            JaggedMultidimentsionalArray();
        }

        private static void JaggedMultidimentsionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            //Array of arrays
            //Here we have an array of 5 diffenent arrays
            int[][] myJagArray = new int[5][];

            //Create th jagged array
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            //print each row (remember, each element is defaulted to zero!)
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
