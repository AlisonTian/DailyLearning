using System;
using System.Collections.Generic;
using System.Text;

namespace TT.OOP.Assignment1.Solution
{
    public static class Command
    {
        public static readonly string PLACE = "PLACE";
        public static readonly string MOVE = "MOVE";
        public static string LEFT = "LEFT";
        public static readonly string RIGHT = "RIGHT";
        public static readonly string REPORT = "REPORT";

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    public enum Command1
    {
        PLACE,
        MOVE,
        LEFT,
        RIGHT,
        REPORT
    }
}