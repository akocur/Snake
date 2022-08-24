using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Figure
    {
        protected List<Point> points;

        public void Drow()
        {
            foreach (Point point in points)
            {
                point.Drow();
            }
        }
    }
}
