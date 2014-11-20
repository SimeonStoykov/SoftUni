using System;

class DiamondTrolls
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int outerDots = (N + 1) / 2;
        int width = N * 2 + 1;

        Console.WriteLine(new String('.', outerDots) + new String('*', N) 
                        + new String('.', outerDots)); //top of the diamond
        outerDots--;
        int innerDots = outerDots;
        for (int i = 0; i < N/2; i++)
        {
            Console.WriteLine(new String('.', outerDots) + "*" + new String('.', innerDots) + "*" 
                            + new String('.', innerDots) + "*" + new String('.', outerDots));
            if (i != N / 2 - 1)
            {
                outerDots--;
                innerDots++;
            }
        }

        Console.WriteLine(new String ('*', width));
      
        for (int i = 0; i < N-1; i++)
        {
            Console.WriteLine(new String('.', outerDots) + "*" + new String('.', innerDots) + "*" 
                            + new String('.', innerDots) + "*" + new String('.', outerDots));
            outerDots++;
            innerDots--;
        }

        Console.WriteLine(new String('.', N) + "*" + new String('.', N));
    }
}