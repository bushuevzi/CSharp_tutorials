using System;

namespace Employees
{
    abstract partial class Employee
    {
        //Field data
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

        //Contain a BenefitPackage object
        protected BenefitPackage empBenefits = new BenefitPackage();
        //Expose certain benefit behaviors of object
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
        //Expose object through a custom property
        public BenefitPackage Benefits
        {
            get => empBenefits;
            set => empBenefits = value;
        }


        //Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }

        public string SocialSecurityNumber
        {
            get => empSSN;
        }

        public int Age
        {
            get => empAge;
            set => empAge = value;
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
    }
}
