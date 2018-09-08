using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use "as" to test compatibility.
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            things[3] = "Last thing";

            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if(h == null)
                    Console.WriteLine("Item is not a hexagon");
                else
                {
                    h.Draw();
                }
            }
        }

        static void CastingExamples()
        {
            //A Manager "is-a" System.Object, so we can
            //store a Manager reference in an object variable just fine
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GivePromotion((Manager)frank);
            Hexagon hex;
            try
            {
                hex = (Hexagon)frank;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //A Manager "is-an" Employee too
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit); //send as argument - Manager Instead Employee

            //A PTSalesPerson "is-a" SalesPerson
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill); //send as argument - PTSalesPerson instead Employee
        }

        static void GivePromotion(Employee emp)
        {
            //Increase pay...
            //Give new parking spase in company garage...
            Console.WriteLine($"{emp.Name} was promoted!");

            switch (emp)
            {
                case SalesPerson s:
                    Console.WriteLine($"{s.Name} made {s.SalesNumber}");
                    break;
                case Manager m:
                    Console.WriteLine($"{m.Name} had {m.StockOptions} stock options...");
                    break;
            }
        }
    }
}
