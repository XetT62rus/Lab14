using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Мурка");
            Dog dog1 = new Dog("Дружок");
            cat1.ShowInfo();
            dog1.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Cat (string name)
            :base(name)
        {

        }

        public override void Say()
        {
            Console.WriteLine("Мяу"); 
        }
    }
    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name)
            : base(name)
        {

        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
