using System;

namespace EPAM_TAO_M2_ConsoleApp
{
    //Abstraction
    abstract class Animal
    {
        //Encapsulation
        private string strAnimalName { get; set; }
        public string StrAnimalName
        {
            get { return strAnimalName; }
            set { strAnimalName = value; }
        }
        public abstract void Sound();

        //Static Polymorphism
        public void Sleep()
        {
            Console.WriteLine("Sleeping.Zzz...");
        }
        public void Sleep(string StrAnimalName)
        {
            Console.WriteLine(StrAnimalName + " is sleeping.Zzz...");
        }

    }

    class Dog : Animal
    {
        //Dynamic Polymorphism
        public override void Sound()
        {
            Console.WriteLine("Bhau, bhau...");
        }

        static void Main(string[] args)
        {
            Dog _dog = new Dog();

            _dog.Sound();
            _dog.Sleep();

            _dog.StrAnimalName = "Tommy";
            _dog.Sleep(_dog.StrAnimalName);
        }
    }
}
