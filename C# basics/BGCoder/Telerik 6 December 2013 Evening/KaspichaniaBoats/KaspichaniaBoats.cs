using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int outerDots = N;
        int innerDots = 0;

        Console.WriteLine("{0}*{0}", new String ('.', outerDots));

        for (int i = 0; i < N - 1; i++)
        {
            outerDots--;
            Console.WriteLine("{0}*{1}*{1}*{0}", new String ('.', outerDots), new String ('.', innerDots));
            innerDots++;
        }

        Console.WriteLine(new String ('*', N*2 + 1));

        for (int i = 0; i < N / 2; i++)
        {
            innerDots--;
            Console.WriteLine("{0}*{1}*{1}*{0}", new String('.', outerDots), new String('.', innerDots));
            outerDots++;            
        }

        Console.WriteLine("{0}{1}{0}", new String('.', outerDots), new String ('*', N));
    }
}