using System;

namespace TT.Day4.OOP_Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat1 = new Cat();

            Dog d1 = new Dog();
            Human h1 = new Human(d1);

            Animal cat = new Cat();
            Human h2 = new Human(cat);

            h1.AnimalRun();
            h2.AnimalRun();
            Console.ReadKey();
        }
    }
}
