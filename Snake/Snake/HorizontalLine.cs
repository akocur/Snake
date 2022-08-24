using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class HorizontalLine
    {
        private List<Point> points;

        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            points = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point point = new(x, y, symbol);
                points.Add(point);
            }
        }

        public void Drow()
        {
            foreach(Point point in points)
            {
                point.Drow();
            }
        }
    }
}
