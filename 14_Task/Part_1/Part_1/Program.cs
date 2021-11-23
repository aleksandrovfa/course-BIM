using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание 4 экземпляров 2 классов Dog и Cat
            Dog dog = new Dog();
            Dog dog1 = new Dog("Пирожок");
            Cat cat = new Cat();
            Cat cat1 = new Cat("Васька");

            dog.ShowInfo();
            dog1.ShowInfo();
            cat.ShowInfo();
            cat1.ShowInfo();

            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal()
        {
            Name = "Санек"; 
        }

        public abstract void Say();
        public void ShowInfo()
        {
            Console.Write("Объект класса {0} с именем {1} говорит: ", GetType().Name,Name);
            Say();
        }
    }

    public class Dog : Animal
    {
        public override string Name { get; set; }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
        public Dog(string name)
            :base()
        {
            Name = name;
        }
        public Dog()
            : base()
        {

        }
    }

    public class Cat : Animal
    {
        public override string Name { get; set; }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
        public Cat(string name)
            : base()
        {
            Name = name;
        }
        public Cat()
            : base()
        {

        }
    }
}
