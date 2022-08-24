using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Rectangle : Figure
    {
        Point leftTopPoint;
        int width;
        int hight;

        public Rectangle(Point leftTopPoint, int width, int hight)
        {
            this.leftTopPoint = leftTopPoint;
            this.width = width;
            this.hight = hight;
            this.points = new List<Point>();

            CreateTopVerticalLine();
            CreateRightVerticalLine();
            CreateLowerVerticalLine();
            CreateLeftVerticalLine();            
        }

        void CreateTopVerticalLine()
        {
            for (int i = 0; i < this.width; i++)
            {
                Point point = new(this.leftTopPoint);
                point.Move(i, Direction.RIGHT);
                points.Add(point);
            }
        }

        void CreateLowerVerticalLine()
        {
            for (int i = 0; i < this.width; i++)
            {
                Point point = new(this.leftTopPoint);
                point.Move(this.hight - 1, Direction.DOWN);
                point.Move(i, Direction.RIGHT);
                points.Add(point);
            }
        }

        void CreateRightVerticalLine()
        {
            for (int i = 0; i < this.hight; i++)
            {
                Point point = new(this.leftTopPoint);
                point.Move(this.width - 1, Direction.RIGHT);
                point.Move(i, Direction.DOWN);
                points.Add(point);
            }
        }
        void CreateLeftVerticalLine()
        {
            for (int i = 0; i < this.hight; i++)
            {
                Point point = new(this.leftTopPoint);
                point.Move(i, Direction.DOWN);
                points.Add(point);
            }
        }
    }
}
