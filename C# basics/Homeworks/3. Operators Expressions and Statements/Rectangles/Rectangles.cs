using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimenter = 2 * width + 2 * height;
        double area = width * height;
        Console.WriteLine("The perimeter is: {0} The area is: {1}", perimenter, area);
    }
}