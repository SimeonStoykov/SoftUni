using System;

class TelerikLogo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int heightAndWidth = (n * 3) - 2;
        int leftLStar = (n / 2) + 1;
        int leftRStar = (n / 2) + 1;
        int rightLStar = heightAndWidth - (n / 2);
        int rightRStar = heightAndWidth - (n / 2);

        for (int rows = 1; rows <= (n / 2) + 1 + (n - 1 - ((n / 2) + 1)); rows++)
        {
            for (int cols = 1; cols <= heightAndWidth; cols++)
            {
                if (cols == leftLStar || cols == leftRStar || cols == rightLStar || cols == rightRStar)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            leftLStar--;
            leftRStar++;
            rightLStar--;
            rightRStar++;
            Console.WriteLine();
        }

        int leftStar = heightAndWidth / 2 + 1;
        int rightStar = heightAndWidth / 2 + 1;

        for (int rows = 1; rows <= (n*2)-1; rows++)
        {
            for (int cols = 1; cols <= heightAndWidth; cols++)
            {
                if (cols == leftStar || cols == rightStar)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            if (rows < n)
            {
                leftStar--;
                rightStar++;
            }
            else
            {
                leftStar++;
                rightStar--;
            }            
            Console.WriteLine();
        }
    }
}