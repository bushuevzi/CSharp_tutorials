using System;

namespace _010_Generics
{
    class Animal { }
    class Cat : Animal { }

    class Program
    {
        delegate void MyDelegate<in T>(T a);

        public static void AnimalUser(Animal animal)
        {
            Console.WriteLine(animal.GetType().Name);
        }

        static void Main(string[] args)
        {
            MyDelegate<Animal> delegateAnimal = new MyDelegate<Animal>(AnimalUser);
            MyDelegate<Cat> delegateCat = new MyDelegate<Animal>(AnimalUser);

            delegateAnimal(new Animal());
            delegateCat(new Cat());
        }
    }
}
