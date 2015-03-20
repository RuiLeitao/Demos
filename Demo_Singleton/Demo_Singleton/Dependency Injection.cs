using System;

namespace Demo_Singleton
{
    class Dependency_Injection
    {
        public Dependency_Injection()
        {

        }
    }

    interface IPerson
    {
        public string name { get; set; }
        public int age { get; set; } 

    }

    interface ISpeak()
    {
        void Speak();
    }

    public class English: IPerson, ISpeak
    {
        public English()
        {
            name = "Jonh";
            age = 23;
        }

        public string name
        {
            get;
            set;
        }

        public int age
        {
            get;
            set;
        }

        public void Speak()
        {
            Console.WriteLine("English: {0}", name);
        }
    }

    public class Portuguese: IPerson, ISpeak
    {
        public Portuguese()
        {
            name = "Rui";
            age = 30;
        }

        public string name
        {
            get;
            set;
        }

        public int age
        {
            get;
            set;
        }

        public void Speak()
        {
            Console.WriteLine("Portuguese: {0}", name);
        }
    }

}
