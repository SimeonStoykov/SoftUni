using System;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = n-1;
        int innerDots = n;

        Console.WriteLine(new String('.', n) + new String('*', n) + new String('.', n));

        for (int i = 1; i <= (n/2)-1; i++)
        {
            Console.WriteLine(new String('.', outerDots) + '*' + new String('.', innerDots) + '*' 
                            + new String('.', outerDots));
            outerDots--;
            innerDots += 2;
        }

        Console.WriteLine(new String('*', (n / 2) + 1) + new String('.', 3*n - (2*((n / 2) +1))) 
                        + new String ('*', (n/2)+1));

        for (int i = 1; i <= (n/2)-2; i++)
        {
            Console.WriteLine('*' + new String('.', (3*n)-2) + '*');
        }

        Console.WriteLine(new String ('*', 3*n));

        for (int i = 1; i <=(n/2)-2; i++)
        {
            Console.WriteLine(new String('.', n / 2) + '*' + new String('.', (n / 2) - 1) + '*' + new String('.', (n - 2))
                            + '*' + new String('.', (n / 2) - 1) + '*' + new String('.', n / 2));
        }

        Console.WriteLine(new String('.', n / 2) + new String('*', (n / 2) + 1) + new String('.', (n - 2)) 
                        + new String('*', (n / 2) + 1) + new String('.', n / 2));
    }
}