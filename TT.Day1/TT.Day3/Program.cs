using System;

namespace TT.Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 0;
           
            Bank anz = new Bank();
            //anz.Found = 10;
            //anz.Name = null;
            anz.SetName(null);
            anz.Start();

            int myCredit = anz.DoubleCredit(3);
            Console.WriteLine(myCredit);
            //Console.WriteLine(anz.Name);


            int b = 1;
            //------------------------------------
            Bank westpac = new Bank();
            westpac.SetName("Westpac");
            westpac.Start();

            // --------------------------
            Triangle tian = new Triangle();
            Console.WriteLine(tian.Name);


            Square s1 = new Square();
            s1.CalArea(2);
            s1.CalArea();

            Square s2 = new Square(2);

            Shape shape = new Triangle();
            Console.ReadKey();
        }
    }
}
