using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc(10, 5);
            c.Add();
        }
    }

    class Calc
    {
        private int x, y;

        public Calc(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Add(int x, int y)
        { Console.WriteLine($"x + y = {x+y}"); }
        
        public void Add()
        { Console.WriteLine($"x + y = {this.x+this.y}"); }

    }
}
