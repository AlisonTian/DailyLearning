using System;
using System.Collections.Generic;
using System.Text;

namespace TT.Day3
{
    public class Bank
    {
        //public string Name { get; set; }
     
        private string Name;

        public int Found;

        public void SetName(string name)
        {
            if (name == null) {
                //throw new Exception("name is not null");
            }
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }


        public void Start()
        {
            Console.WriteLine(Name + " 开业了");
        }

        public int DoubleCredit(int credit)
        {
            int result = credit * 2;
            return result;
        }
    }
}
