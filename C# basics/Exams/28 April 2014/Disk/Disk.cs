//(x-centerX)^2 + (Y-centerY)^2 <= r^2 -> the point is in the DISK (if it is "<" the point is only in the circle)
using System;

class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                if (Math.Abs(col - (n + 1) / 2) * Math.Abs(col - (n + 1) / 2)
                  + Math.Abs(row - (n + 1) / 2) * Math.Abs(row - (n + 1) / 2) <= Math.Pow(r, 2))
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}