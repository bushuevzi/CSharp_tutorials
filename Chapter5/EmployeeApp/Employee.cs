using System;

namespace EmployeeApp
{
    partial class Employee
    {
        //Field data
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        

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
