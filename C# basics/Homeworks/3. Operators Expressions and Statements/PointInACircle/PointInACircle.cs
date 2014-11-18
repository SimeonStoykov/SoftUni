using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        bool isInside = (x * x) + (y * y) <= (2 * 2);
        Console.WriteLine("These coordinates are inside the circle = " + isInside);
    }
}