using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double buffer = a;

        if (b >= buffer)
        {
            buffer = b;
        }
        if (c >= buffer)
        {
            buffer = c;
        }
        if (d >= buffer)
        {
            buffer = d;
        }
        if (e >= buffer)
        {
            buffer = e;
        }

        Console.WriteLine(buffer);
    }
}

