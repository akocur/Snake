using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
        public int x;
        public int y1;
        public char symbol;

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y1 = _y;
            symbol = _symbol;
        }

        public void Drow() 
        {
            Console.SetCursorPosition(x, y1);
            Console.Write(symbol);
        }
    }
}
