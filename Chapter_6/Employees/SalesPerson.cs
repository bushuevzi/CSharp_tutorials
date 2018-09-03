using System;

namespace Employees
{
    //Salespeople need to know their number of sales
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }
        //As a general rule, all subclasses should explicitly call an appropriate
        //base class constructor
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales)
            :base(fullName, age,empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
    }
}
