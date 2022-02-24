using System;

namespace TT.OOP.Assignment1.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(5, 5);
           
            Console.WriteLine(Command.MOVE);
            Console.WriteLine(Command.Add(1, 2));
            Console.WriteLine(Command1.REPORT);
            Command.LEFT = "MOVE LEFT";
            Console.ReadKey();

        }
    }
}
