using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Car
    {
        //Intrenal state data
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        //Is the car alive or dead?
        private bool carIsDead;

        //Class constructors
        public Car() { }

        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        // Выполним 3 действия(шага) указанные выше
        // 1) Определим делегат
        public delegate void CarEngineHandler(string msgFoCaller);
        // 2) Определим член-переменную для этого делегата
        private CarEngineHandler listOfHandlers;
        // 3) Добавим учетную(регистрирующую) функцию для вызывающего кода. 
        // эта функция позволяет вызывающему коду добавлять метод в список вызовов делегата
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall; //благодоря оператору += мы можем создать список связанных методов для многопоточной обработки этих методов
        }
        // Чтобы позволить объекту Car отправлять связанные с двигателем сообщения любому подпи-
        // савшемуся прослушивателю.
        // 4) Реализуем Accelerate() для обрашения к списку вызовов делегата в подходящих обстоятельствах
        public void Accelerate(int delta)
        {
            //if this car is "dead", send dead message
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry, this car is dead");
            }
            else
            {
                CurrentSpeed += delta;
                //is this car "almost dead"? 
                if(10 == (MaxSpeed - CurrentSpeed) && listOfHandlers !=null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}
