using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class VerticalLine
    {
        private List<Point> points;

        public VerticalLine(int yUp, int yDown, int x, char symbol)
        {
            points = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point point = new(x, y, symbol);
                points.Add(point);
            }
        }

        public void Drow()
        {
            foreach (Point point in points)
            {
                point.Drow();
            }
        }
    }
}
