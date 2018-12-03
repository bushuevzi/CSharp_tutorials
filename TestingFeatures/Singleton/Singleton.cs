using System;

namespace Singleton
{
    class Singleton
    {
        private static Singleton instance = null;

        protected Singleton() { }

        public static Singleton Instance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
