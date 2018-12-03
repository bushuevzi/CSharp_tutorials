using System;

namespace _009_Generics
{
    class Animal { }
    class Cat : Animal { }

    class Program
    {
        delegate T MyDelegate<out T>();
        public static Cat CatCreator()
        { return new Cat(); }

        static void Main(string[] args)
        {
            MyDelegate<Cat> delegateCat = new MyDelegate<Cat>(CatCreator);
            MyDelegate<Animal> delegateAnimal = new MyDelegate<Cat>(CatCreator);

            Animal animal = delegateAnimal();
            Console.WriteLine(animal.GetType().Name);
        }
    }
}
