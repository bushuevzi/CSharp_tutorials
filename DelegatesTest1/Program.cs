using System;
using System.Linq;

namespace DelegatesTest1
{
    public delegate int CountDelegate(string message); // делегат может хранить ссылку на метод который будет схож по сигнатуре

    class Program
    {
        static void Main(string[] args)
        {
            StringHelper helper = new StringHelper();

            CountDelegate d1 = helper.GetCount; //у метода GetCount - схожая сигнатура с делегатом, приравниваем ссылку на метод в делегат (связываем метод и делегат)
            CountDelegate d2 = helper.GetCountSymbolA; //у метода GetCountSymbolA - схожая сигнатура с делегатом, приравниваем ссылку на метод в делегат (связываем метод и делегат) 

            string testString = "LAMP";
            Console.WriteLine($"Общее количество символов {TestDelegate(d1, testString)}"); //с помощью вспомогатеьлной фунции проверяем работу первого делегата d1 и связанной с ним функции
            Console.WriteLine($"Количество символов А: {TestDelegate(d2, testString)}");     //с помощью вспомогательно функции проверяем работу второго делегата 

        }

        // вспомогательная функция для передачи в нее тестируемого делегат 
        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }
    }

    public class StringHelper
    {
        public int GetCount(string inputString)
        {
            return inputString.Length;
        }

        public int GetCountSymbolA(string inputString)
        {
            return inputString.Count(c => c == 'A');
        }

        public int GetCountSymbol(string inputString, char symbol)
        {
            return inputString.Count(c => c == symbol);
        }
    }
}
