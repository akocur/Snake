using System;
using Snake;

internal class Program
{
    private static void Main(string[] args)
    {
        Point p1 = new()
        {
            x1 = 1,
            y1 = 3,
            symbol = '*'
        };
        p1.Drow();

        Point p2 = new()
        {
            x1 = 4,
            y1 = 5,
            symbol = '#'
        };
        p2.Drow();

        Console.ReadLine();
    }
}