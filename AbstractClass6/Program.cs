using System;

namespace AbstractClass6
{
   abstract class Animal
    {
        protected string name;
        protected int age;
        //abstract method
        public abstract string Name
        {
            get;
            set;
        }
        public abstract int Age
        {
            get;
            set;
        }
    }

    //inheriting from abstract class
    class Dog : Animal
    {
        //provide implimation of abstract method
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
    class Program
    {
        static void Main (string [] args)
        {
            //create an object of Dog class
            Dog dog = new Dog();
            dog.Name = "Tom";
            dog.Age = 5;
            Console.WriteLine("Name : " + dog.Name);
            Console.WriteLine("Age : " + dog.Age);

            Console.ReadLine();
        }
    }
}
