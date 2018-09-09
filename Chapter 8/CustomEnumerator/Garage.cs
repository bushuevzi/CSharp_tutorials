using System;
using System.Collections;

namespace CustomEnumerator
{
    class Garage : IEnumerable
    {
        //Sytem.Array already implements IEnumerator!
        private Car[] carArray = new Car[4];

        //Fill with some Car Objrcts upon startup
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        //делегируем вызов метода GetEnumerator() в реализацию внутри массива Array
        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }
}
