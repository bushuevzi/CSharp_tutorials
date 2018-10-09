using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesTest1
{
    delegate string FirstDelegate(int x);
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Sample
    {
        delegate void SecondDelegate(char a, char b);
    }
}
