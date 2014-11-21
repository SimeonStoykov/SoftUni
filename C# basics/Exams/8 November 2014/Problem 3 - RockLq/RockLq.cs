using System;

class RockLq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = n - 2;
        int innerDots = n + 2;

        for (int row = 1; row <= (n + 1) / 2; row++)
        {
            if (row == 1)
            {
                Console.WriteLine("{0}{1}{0}", new String('.', n), new String('*', n));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}", new String('.', outerDots), 
                                                 new String('.', innerDots));
                outerDots -= 2;
                innerDots += 4;
            }
        }

        Console.WriteLine("*{0}*{1}*{0}*", new String('.', n - 2), new String('.', n));

        outerDots = n - 4;
        innerDots = n;
        int middleDots = 1;

        for (int row = 1; row <= (n - 2) / 2; row++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new String('.', outerDots), 
                          new String('.', middleDots), new String('.', innerDots));
            outerDots -= 2;
            middleDots += 2;
        }

        outerDots = n - 1;
        innerDots = n;

        for (int row = 1; row <= n; row++)
        {
            if (row != n)
            {
                Console.WriteLine("{0}*{1}*{0}", new String('.', outerDots),
                                                 new String('.', innerDots));
                outerDots--;
                innerDots += 2;
            }
            else
            {
                Console.WriteLine(new String('*', 3 * n));             
            }
        }
    }
}