using System;
using Snake;

internal class Program
{
    private static void Main(string[] args)
    {
        Point p1 = new(1, 3, '*');
        p1.Drow();

        Point p2 = new(4, 5, '#');
        p2.Drow();

        List<Point> points = new()
        {
            p1,
            p2
        };

        foreach (Point p in points)
        {
            Console.WriteLine(p);
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
            Console.WriteLine(p.symbol);
        }


        Console.ReadLine();
    }
}