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
        public int y;
        public char symbol;

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            this.symbol = point.symbol;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                    x += offset;
                    break;
                case Direction.LEFT:
                    x -= offset;
                    break;
                case Direction.UP:
                    y -= offset;
                    break;
                case Direction.DOWN:
                    y += offset;
                    break;
            }
        }

        public void Drow() 
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
