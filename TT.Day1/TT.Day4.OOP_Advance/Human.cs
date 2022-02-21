using System;
using System.Collections.Generic;
using System.Text;

namespace TT.Day4.OOP_Advance
{
    public class Human
    {
        private Animal _animal;
        public Human(Animal animal)
        {
            _animal = animal;
        }
        public void SetAnimal(Animal animal)
        {
            _animal = animal;
        }
        public void AnimalRun()
        {
            _animal.Run();
        }
    }
}
