using System;
using System.Collections.Generic;
using System.Text;

namespace TT.Day3
{
    public class Square 
    {
        public int Length;

        public Square()
        {
            Length = 10;
        }

        public Square(int num)
        {
            Length = num;
        }

        public int CalArea()
        {
            int area = Length * Length;
            return area;
        }

        public int CalArea(int length)
        {
            int area = length * length;
            return area;
        }
    }
}
