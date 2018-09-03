using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingAccount
    {
        //Instance-level data.
        public double currBallance;

        //A static point of data
        public static double currInterestRate;

        //Notice that our constructor is setting
        //the static currInterestRate value
        public SavingAccount(double balance)
        {
            currBallance = balance;
        }
        
        // A static Constructor!
        static SavingAccount()
        {
            Console.WriteLine("In static ctor");
            currInterestRate = 0.04;
        }

        //A static property.
        public static double InterestRate
        {
            get => currInterestRate;
            set => currInterestRate = value;
        }

    }
}
