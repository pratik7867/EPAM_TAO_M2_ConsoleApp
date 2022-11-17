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
            set {

                if (!string.IsNullOrEmpty(value))
                {
                    strAnimalName = value;
                }
                else
                {
                    //Custom Exception
                    throw new EmptyStringException("Name cannot be empty");
                }
            }
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
            //Dynamic Polymorphism
            Animal _dog = new Dog();
            _dog.StrAnimalName = "Tommy";

            _dog.Sound();
            _dog.Sleep();
            
            _dog.Sleep(_dog.StrAnimalName);

            //Equals Overridden
            Employee e1 = new Employee();
            e1.Id = 1;
            e1.Name = "EmpTest";

            Employee e2 = new Employee();
            e2.Id = 1;
            e2.Name = "EmpTest";

            Console.WriteLine(e1.Equals(e2));
        }
    }
}
