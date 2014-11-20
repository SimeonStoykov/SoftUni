using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = (n - 2) / 2;
        int innerDots = 0;

        for (int i = 1; i <= n/2; i++)
        {
            Console.WriteLine(new String ('.', outerDots) + '#' + new String('.', innerDots) 
                            + '#' + new String('.', outerDots));
            if (i < n/2)
            {
                outerDots--;
                innerDots += 2;                
            }                     
        }

        for (int i = 1; i <= n/4; i++)
        {
            Console.WriteLine(new String('.', outerDots) + '#' + new String('.', innerDots) 
                            + '#' + new String('.', outerDots));
            outerDots++;
            innerDots -= 2;
        }

        Console.WriteLine(new String('-', n));

        int dots = 0;
        int slashes = n / 2;
        for (int i = 1; i <= n/2; i++)
        {
            Console.WriteLine(new String('.', dots) + new String('\\', slashes) 
                            + new String('/', slashes) + new String('.', dots));
            dots++;
            slashes--;
        }
    }
}