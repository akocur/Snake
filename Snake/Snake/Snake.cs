using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            for (int i=0; i<length; i++)
            {
                Point point = new(tail);
                point.Move(i, direction);
                points.Add(point);
            }
        }

    }
}
