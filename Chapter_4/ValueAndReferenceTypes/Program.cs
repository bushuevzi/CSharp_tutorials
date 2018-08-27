using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeAssignment();
        }
        
        //Assigning to intrinsic value types results in 
        //two independent variables on the stack.
        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assinging value types\n");

            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            //Print both points.
            p1.Display();
            p2.Display();

            //Chage p1.X and print again. p2.X is changed to by reference
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }

        class PointRef
        {
            //Fields of the structure
            public int X;
            public int Y;

            //A custom constructor
            public PointRef(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }

            //Add 1 to the (X,Y) position
            public void Increment()
            {
                X++; Y++;
            }

            //Subtract 1 from the (X,Y) position
            public void Decrement()
            {
                X--; Y--;
            }

            //Display the current position
            public void Display()
            {
                Console.WriteLine($"X = {X}, Y = {Y}");
            }
        }
    }
}
