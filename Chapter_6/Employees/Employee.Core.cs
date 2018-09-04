using System;

namespace Employees
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

        public Employee(string name, int age, int id, float pay, string ssn)
            :this(name, age,id,pay)
        {
            empSSN = ssn;
        }

        //Methods
        //Thiss method can now be "overridden" by a derived class
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }
        //Updated 
        public virtual void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"SSN: {SocialSecurityNumber}");
        }
    }
}
