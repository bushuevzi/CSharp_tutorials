using System;

namespace Employees
{
    //Managers need to know their number of stock options
    class Manager : Employee
    {
        public int StockOptions { get; set; }
        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
            :base(fullName, age,empID,currPay, ssn)
        {
            //This property is defined by the manager class
            StockOptions = numbOfOpts;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Number of Stock Options: {StockOptions}");
        }
    }
}
