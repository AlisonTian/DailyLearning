using System;
using System.Collections.Generic;
using System.Text;

namespace TT.Day4.OOP_Advance
{
    public class Dog : Animal
    {
        public  string Name { get; set; }
        
        public string GetName()
        {
            Console.WriteLine("Dog");
            return Name;
        }

        public void Run()
        {
            Console.WriteLine("Gog Run");
        }
    }
}
