using System;

class TicTacToePower 
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        long V = long.Parse(Console.ReadLine());
        long index = 0;

        if (x==0 && y==0)
        {
            index = 1;
        }
        if (x == 1 && y == 0)
        {
            index = 2;
        }
        if (x == 2 && y == 0)
        {
            index = 3;
        }
        if (x == 0 && y == 1)
        {
            index = 4;
        }
        if (x == 1 && y == 1)
        {
            index = 5;
        }
        if (x == 2 && y == 1)
        {
            index = 6;
        }
        if (x == 0 && y == 2)
        {
            index = 7;
        }
        if (x == 1 && y == 2)
        {
            index = 8;
        }
        if (x == 2 && y == 2)
        {
            index = 9;
        }

        V = V + index - 1;
        V = (long)Math.Pow(V, index);
        Console.WriteLine(V);
    }
}