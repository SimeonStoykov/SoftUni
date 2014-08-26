using System;

class Arrow
{
    static void Main()
    {
        int n =int.Parse(Console.ReadLine());
        int outerDotsCount = n / 2;
        int innerDotsCount = n - 2;

        for (int i = 1; i <=n; i++)
        {
            if (i==1)
            {
                Console.WriteLine(new String('.', outerDotsCount) + new String('#', n) + new String('.', outerDotsCount));
            }
            if (i>1 && i<n)
            {
                Console.WriteLine(new String('.', outerDotsCount) + '#' + new String('.', innerDotsCount) +  '#' 
                                + new String('.', outerDotsCount));
            }
            if (i==n)
            {
                Console.WriteLine(new String('#', (n+1)/2) + new String('.', n-2) +  (new String('#', (n+1)/2)));
            }
        }

        int outerDots = 1;
            
        for (int i = 1; i <= n-2; i++)
        {
            Console.WriteLine(new String('.', outerDots) + '#' + new String('.', (n*2-1)-(2+outerDots*2)) + '#' 
                            + new String('.', outerDots));
            outerDots++;
        }

        Console.WriteLine(new String('.', n-1) + '#'+ new String('.', n-1));            
    }
}