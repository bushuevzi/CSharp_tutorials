using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChP_3_TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            NarrowingAttamp();
        }

        private static void NarrowingAttamp()
        {
            byte b1 = 100;
            byte b2 = 250;

            try
            {
                //checked - tell compiler to add CIL code to throw an except/ if oberflow/underflow
                checked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine($"sum = {sum}");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int Add(int b1, int b2)
        {
            return b1 + b2;
        }
    }
}
