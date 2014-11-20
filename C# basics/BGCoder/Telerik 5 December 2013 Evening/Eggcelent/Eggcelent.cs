using System;

class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstStars = n - 1;
        int innerDots = n + 1;
        int outerDots = n + 1;
        int width = 3 * n + 1;
        int specialFirstRow = 3;
        int specialSecondRow = 4;
        int downOuterDots = 0;
        int downInnerDots = 0;

        Console.WriteLine(new String('.', outerDots) + new String('*', firstStars) + new String('.', outerDots));

        for (int i = 1; i <= (n-2)/2; i++)
        {
            outerDots -=2;
            Console.WriteLine(new String('.', outerDots) + '*' + new String('.', innerDots) + '*' + new String('.', outerDots));
            innerDots += 4;

            if (i == (n-2)/2)
            {
                downOuterDots = outerDots;
                downInnerDots = innerDots - 4;
            }
        }

        for (int row = 1; row <= (n-2)/2; row++)
        {                                     
         Console.WriteLine("." + "*" + new String('.', innerDots) + "*" + ".");                
        }

        for (int row = 1; row <= 2; row++)
        {
            for (int col = 1; col <= width; col++)
            {
                if (row == 1)
                {
                    if (col == 1)
                    {
                        Console.Write(".");
                    }
                    else if (col == 2)
                    {
                        Console.Write("*");
                    }
                    else if (col == width)
                    {
                        Console.Write(".");
                    }
                    else if (col == width - 1)
                    {
                        Console.Write("*");
                    }
                    else if (col == specialFirstRow)
                    {
                        Console.Write("@");
                        specialFirstRow += 2;
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else
                {
                    if (col == 1)
                    {
                        Console.Write(".");
                    }
                    else if (col == 2)
                    {
                        Console.Write("*");
                    }
                    else if (col == width)
                    {
                        Console.Write(".");
                    }
                    else if (col == width - 1)
                    {
                        Console.Write("*");
                    }
                    else if (col == specialSecondRow)
                    {
                        Console.Write("@");
                        specialSecondRow += 2;
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }
            Console.WriteLine();
        }

        for (int row = 1; row <= (n - 2) / 2; row++)
        {
            Console.WriteLine("." + "*" + new String('.', innerDots) + "*" + ".");
        }

        for (int i = 1; i <= (n - 2) / 2; i++)
        {
            Console.WriteLine(new String('.', downOuterDots) + "*" + new String('.', downInnerDots) + "*" + new String('.', downOuterDots));
            downOuterDots += 2;
            downInnerDots -= 4;
        }

        Console.WriteLine(new String('.', n + 1) + new String('*', n - 1) + new String('.', n + 1));      
    }
}