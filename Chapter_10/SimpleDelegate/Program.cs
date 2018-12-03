using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a BinaryOp delegate object that "points to" SimpleMath Add()
            BinaryOp b = new BinaryOp(SimpleMath.Add);
            DisplayDelegateInfo(b);

            Console.WriteLine($"10 + 10 is {b(10, 10)}");
        }
        static void DisplayDelegateInfo(Delegate delObj)
        {
            //print the names of each member int the delegate's inbocation list
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine($"Method Name: {d.Method}");
                Console.WriteLine($"Target Name: {d.Target}");
            }
        }
    }

    //This delegate can point to any method taking two integers and returning an integer
    public delegate int BinaryOp(int x, int y);

    //This class contains methods BinaryOp will point to
    public class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Substract(int x, int y) => x - y;
    }

}
