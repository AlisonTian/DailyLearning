using System;
using System.Collections.Generic;
using System.Text;

namespace TT.Day3
{
    public abstract class Shape
    {
        public Shape() { 
        }

        public Shape(int num)
        {

        }
        public string Name { get; set; }
        public virtual void CallMyName()
        {
            Console.WriteLine(Name);
        }

        public abstract int CalArea();

    }
}
