using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            if (instance1 == instance2)
                Console.WriteLine("переменные содержат ссылку на один и тот же экземпляр Singleton");
        }
    }
}
