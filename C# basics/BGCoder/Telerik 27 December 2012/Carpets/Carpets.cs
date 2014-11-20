using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string linesLeft = "\\";
        string linesRight = "/";

        int bottomDots = 1;

        //First Row
        Console.WriteLine(new String('.', (n/2) - 1) + "/\\" + new String('.', (n/2) - 1));

        //Middle Top

        for (int row = 2; row <= n / 2; row++)
        {
            if ((row % 2) == 0)
            {
                linesRight += " ";
                linesLeft = " " + linesLeft;
            }
            else
            {
                linesRight += "/";
                linesLeft = "\\" + linesLeft;
            }
            string dots = new String('.', (n - (row * 2)) / 2);
            Console.Write(dots);
            Console.Write(linesRight + linesLeft);
            Console.Write(dots);
            Console.WriteLine();
        }

        // Middle Bottom
        linesRight = linesRight.Replace("/", "\\");
        linesLeft = linesLeft.Replace("\\", "/");
        Console.WriteLine(linesRight + linesLeft);
        int index = n / 2 - 1;
        for (int row = n / 2 + 2; row <= n; row++)
        {
            string dots = new String('.', bottomDots);
            Console.Write(dots);
            linesLeft = linesLeft.Remove(0, 1);
            linesRight = linesRight.Remove(index);
            Console.Write(linesRight + linesLeft);
            Console.Write(dots);
            index--;
            Console.WriteLine();
            bottomDots++;
        }
    }
}