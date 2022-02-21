using System;
using System.Collections.Generic;
using System.Text;

namespace TT.Day3
{
    public class Game
    {
        public Enemy Enemy;
        public OurFlight Flight;
        public bool IsTouch()
        {
            if (Enemy.Position.X == Flight.Position.X && Enemy.Position.Y == Flight.Position.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IsGameOver()
        {
            if (IsTouch())
            {
                Console.WriteLine("Game Over");
            }
            
        }
    }

    public class Enemy
    {
        public Position Position { get; set; }
    }

    public class OurFlight
    {
        public Position Position { get; set; }
        public void MoveUp()
        {
            Position.Y = Position.Y + 1;
        }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
