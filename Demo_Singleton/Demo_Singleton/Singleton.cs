using System;

namespace Demo_Singleton
{
    class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance { 
            get { return _instance == null ? new Singleton() : _instance;}
        }

        public Singleton()
        {
            
        }

        public void Speak()
        {
            Console.WriteLine("Singleton Instance");
        }
    }
}
