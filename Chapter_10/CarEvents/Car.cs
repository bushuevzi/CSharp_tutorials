using System;

namespace CarEvents
{
    //Поддерживает строковое представление сообщения, отправляемого получателю
    class CarEventArgs : EventArgs
    {
        public readonly string msg;
        public CarEventArgs(string message)
        { msg = message; }
    }

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
        //Этот делегат работает в сочетании с событиями Car
        public delegate void CarEngineHandler(string msgToCaller);
        //эта машина может отправить следующие события (т.е. вызывающая функция может определить как обработать то или иное событие)
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public void Accelerate(int delta)
        {
            //Если машина умерла то инициируем событие Exploded
            if(carIsDead)
            {
                if (Exploded != null)
                    Exploded("Sorry, this car is dead..."); //указываем конкретно какое событие вызвать
            }
            else
            {
                CurrentSpeed += delta;

                //почти мертва?
                if(10 == MaxSpeed - CurrentSpeed && AboutToBlow !=null)
                {
                    AboutToBlow("Careful buddy! Gonna blow!"); //указываем конкретно какое событие вызвать
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}
