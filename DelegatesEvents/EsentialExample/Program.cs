using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsentialExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public string name { get; set; }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public Point(int x, int y)
            : this(x, y, "Noname") { }

        public Point(string name)
            : this(0, 0, name) { }


    }
}
