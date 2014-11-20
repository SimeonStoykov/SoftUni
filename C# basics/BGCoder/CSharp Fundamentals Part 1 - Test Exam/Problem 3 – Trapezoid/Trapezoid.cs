using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new String ('.', n) + new String('*', n));
        int outerDots = n - 1;
        int innerDots = n - 1;

        for (int row = 1; row <= n + 1 - 2; row++)
        {
            Console.WriteLine("{0}*{1}*", new String('.', outerDots), new String('.', innerDots));
            outerDots--;
            innerDots++;
        }
        Console.WriteLine(new String('*', 2 * n));
    }
}