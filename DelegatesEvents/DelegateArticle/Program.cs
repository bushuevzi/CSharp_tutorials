using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateArticle
{
    //создадим делегат
    delegate int IntOperation(int i, int j);

    class Program
    {
        static void Main(string[] args)
        {
            //Создадим экземпляр делегата
            IntOperation op1 = new IntOperation(Sum);
            Console.WriteLine($"Делегат ссылается на метод: {op1.Method}");
            int result = op1(5, 10);
            Console.WriteLine($"Сумма: {result}");

            //Изменим ссылку на метод
            op1 = new IntOperation(Mult);
            Console.WriteLine($"Делегат ссылается на метод: {op1.Method}");
            result = op1(5, 10);
            Console.WriteLine($"Произведение: {result}");
        }

        //Организуем ряд методов
        static int Sum(int x, int y) { return x + y; }
        static int Mult(int x, int y) { return x * y; }
        static int Dev(int x, int y) { return x / y; }
        static int Sub(int x, int y) { return x - y; }
    }
}
