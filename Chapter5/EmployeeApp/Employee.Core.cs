using System;

namespace EmployeeApp
{
    partial class Employee
    {
        //Updated Constructors
        public Employee() { }
        public Employee(string name, int id, float pay)
            :this(name, 0, id, pay) { }
        
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }

        //Methods
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        //Updated 
        public void DisplayStats()
        {
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"Age: {empAge}");
            Console.WriteLine($"Pay: {currPay}");
        }
    }
}
