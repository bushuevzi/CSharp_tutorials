using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Events
{
    public delegate void PressKeyEventHandler();

    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyB = null;
        public event PressKeyEventHandler PressKeyH = null;

        public void PressKeyAEvent()
        {
            if(PressKeyA != null)
            {
                PressKeyA();
            }
        }

        public void PressKeyBEvent()
        {
            if(PressKeyB != null)
            {
                PressKeyB();
            }
        }

        public void PressKeyHEvent()
        {
            if(PressKeyH != null)
            {
                PressKeyH();
            }
        }

        public void Start()
        {
            while (true)
            {
                string s = Console.ReadLine();
                switch (s)
                {
                    case "a":
                    case "A":
                        PressKeyAEvent();
                        break;
                    case "b":
                    case "B":
                        PressKeyBEvent();
                        break;
                    case "h":
                    case "H":
                        PressKeyHEvent();
                        break;
                    case "exit":
                        goto Exit;
                    default:
                        Console.WriteLine($"Нет обоработчика нажатия на клавишу {s}");
                        break;
                }
            }
            Exit:
            Console.WriteLine("Exit!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();

            keyboard.PressKeyA += PressKeyA_Handler;
            keyboard.PressKeyB += PressKeyB_Handler;
            keyboard.PressKeyH += PressKeyH_Handler;

            keyboard.Start();
        }

        private static void Keyboard_PressKeyB()
        {
            throw new NotImplementedException();
        }

        static private void PressKeyA_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("    X    ");
            Console.WriteLine("   X X   ");
            Console.WriteLine("  X   X  ");
            Console.WriteLine(" XXXXXXX ");
            Console.WriteLine("X        X");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static private void PressKeyB_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("XXXXX  ");
            Console.WriteLine("X    X ");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine("X     X");
            Console.WriteLine("XXXXXX");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static private void PressKeyH_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("X     X");
            Console.WriteLine("X     X ");
            Console.WriteLine("XXXXXXX");
            Console.WriteLine("X     X");
            Console.WriteLine("X     X");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
