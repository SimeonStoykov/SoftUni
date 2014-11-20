using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotsCount = n - 2;
        int startsCount = 1;

        for (int row = 1; row <= n; row++)
        {
            if (row == n)
            {
                Console.WriteLine("{0}*{0}", new String('.', n - 2));
            }
            else 
            {
                Console.WriteLine("{0}{1}{0}", new String('.', dotsCount), new String('*', startsCount));
            }
            dotsCount--;
            startsCount += 2;
        }
    }
}