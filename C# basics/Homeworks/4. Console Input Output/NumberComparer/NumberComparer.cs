using System;

class NumberComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = Math.Max(a, b);
        Console.WriteLine("The greater is: {0}", c);
    }
}

