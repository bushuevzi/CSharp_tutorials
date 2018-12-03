using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point using ints
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine(p.ToString());

            //Point using double
            Point<double> p2 = new Point<double>(5.4, 3.3);
            Console.WriteLine(p2.ToString());
        }
    }
    public struct Point<T>
    {
        //generic state date
        private T xPos;
        private T yPos;

        //Generic constructor
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        //Generic properties
        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public override string ToString()
        {
            return $"[{xPos}, {yPos}]";
        }

        //Reset fields to the default value of the type parameter
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }
    }
}
