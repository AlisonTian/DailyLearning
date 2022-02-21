using System;
using System.Collections.Generic;
using System.Text;

namespace TT.Day3
{
    public class Triangle : Shape
    {
        public Triangle()
        {

        }

        public Triangle(int num):base(num)
        {
        }
    
        public int Height { get; set; }
        public int Long { get; set; }
        public override int CalArea()
        {
            int area = Height * Long / 2;
            return area;
        }

        public override void CallMyName()
        {
            base.CallMyName();
            Console.WriteLine("new code");
        }

    }
}
