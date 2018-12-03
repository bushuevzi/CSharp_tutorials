using System;
using System.Threading;

namespace _001_MatrixExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void SymbolDown()
        {
            // в случайном месте
            int hight = new Random().Next(Console.WindowHeight);
            Console.CursorLeft = new Random().Next(Console.WindowWidth);
            //случайным шлейфом //шлейф будет в виде цикличного буфера
            int traceLength = new Random().Next(Console.WindowHeight - hight);

            //рисуем падающий шлейф, который падает до конца экрана
            for(int i = hight; i < Console.WindowHeight; i++)
            {
                // 1. рисуем случайный символ белым цветом
                

            }
            // 2. рисуем ниже новый случайный символ белым цветом
            // 2.1. предыдущему белому символу меняем свет на зеленый
            // 2.2. предыдущему зеленому цвету меняем цвет на темнозеленный и держим символ до конца шлефа
        }
        
        static char WiteSymbol()
        {
            char symbol = (char)new Random().Next(0x00A0, 0x0db0);
            Console.WriteLine(symbol);
            Console.CursorLeft--; // сдвигаем курсор обратно на столбец в котором падает шлейф
            return symbol;
        }
    }
}
