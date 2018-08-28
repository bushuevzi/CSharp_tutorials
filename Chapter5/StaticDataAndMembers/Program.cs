using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Static Data ****\n");
            SavingAccount s1 = new SavingAccount(50);

            //Print the current interest rate.
            Console.WriteLine($"Interest Rate is: {SavingAccount.GetInterestRate()}");

            //Try to change the interest rate via property
            SavingAccount.SetInterestRate(0.08);

            //Make a second account
            SavingAccount s2 = new SavingAccount(100);
            
            //Should print 0.08...right??
            Console.WriteLine($"Interest Rate is: {SavingAccount.GetInterestRate()}");

        }
    }
}
