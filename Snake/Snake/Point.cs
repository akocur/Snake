using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
        public int x1;
        public int y1;
        public char symbol;

        public void Drow() 
        {
            Console.SetCursorPosition(x1, y1);
            Console.Write(symbol);
        }
    }
}
