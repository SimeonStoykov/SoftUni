using System;

class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 2 * n + 1;
        int dotsCount = n;
        int innerDots = 1;

        Console.WriteLine(new String('.', dotsCount) + '*' + new String('.', dotsCount));

        for (int i = 1; i <= (n/2)-1; i++)
        {
            dotsCount--;
            Console.WriteLine(new String('.', dotsCount) + '*' + new String('.', innerDots) + '*' 
                            + new String('.', dotsCount));
            innerDots += 2;
        }

        Console.WriteLine(new String('*', (n / 2) + 1) + new String('.', (n - 1)) 
                        + new String('*', (n/2) + 1));

        dotsCount = 1;
        for (int i = 1; i <= (n / 2) - 1; i++)
        {
            Console.WriteLine(new String('.', dotsCount) + '*' + new String ('.', width - (2*dotsCount + 2)) 
                      + '*' + new String('.', dotsCount));
            dotsCount++;
        }

        Console.WriteLine(new String('.', n / 2) + '*' + new String('.', (n / 2) - 1) + '*' 
                        + new String('.', (n/2) - 1)+ '*' + new String('.', n / 2));

        dotsCount = (n/2)-1;
        int constDots = dotsCount;
        innerDots = 1;
        for (int i = 1; i <= n/2; i++)
        {
            if (i < n/2)
            {
                Console.WriteLine(new String('.', dotsCount) + '*' + new String('.', constDots) + '*' 
                                + new String('.', innerDots) + '*' + new String('.', constDots) + '*'
                                + new String('.', dotsCount));
                dotsCount--;
                innerDots += 2;
            }
            else
            {
                Console.WriteLine(new String('*', (n / 2) + 1) + new String('.', (n - 1)) 
                                + new String('*', (n / 2) + 1));
            }           
        }
    }
}