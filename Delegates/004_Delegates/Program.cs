using System;

namespace _004_Delegates
{
    public delegate void MyDelegate();

    class Program
    {
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method2");
        }
        public static void Method3()
        {
            Console.WriteLine("Method3");
        }

        static void Main(string[] args)
        {
            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = new MyDelegate(Method2);
            MyDelegate myDelegate3 = new MyDelegate(Method3);

            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

            Console.WriteLine("Введите число от 1 до 7");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        myDelegate1();
                        break;
                    }
                case "2":
                    {
                        myDelegate2();
                        break;
                    }
                case "3":
                    {
                        myDelegate3();
                        break;
                    }
                case "4":
                    {
                        MyDelegate myDelegate4 = myDelegate - myDelegate1;
                        myDelegate4();
                        break;
                    }
                case "5":
                    {
                        MyDelegate myDelegate5 = myDelegate - myDelegate2;
                        myDelegate5();
                        break;
                    }
                case "6":
                    {
                        MyDelegate myDelegate6 = myDelegate - myDelegate3;
                        myDelegate6();
                        break;
                    }
                case "7":
                    {
                        myDelegate();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введено не верное значение.");
                        break;
                    }
            }
        }
    }
}
