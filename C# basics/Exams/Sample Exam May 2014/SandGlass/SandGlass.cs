using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string star = "*";
        string dot = ".";

        for (int i = 1; i <= n; i++)
        {
            for (int m = 1; m <=n; m++)
            {
                if (i==1 || i==n)
                {
                    Console.Write(star, n);
                }
                if (i==(n+1)/2 && m==(n+1)/2)
                {
                    Console.Write(star);
                }
                if (i==(n+1)/2 && m!=(n+1)/2)
                {
                    Console.Write(dot);
                }
                if (i>1 && i< (n+1)/2 && m==n)
                {
                    Console.Write(new String('.', i - 1) + new String('*', n-(i - 1+i-1)) + new String('.', i - 1));
                }
                if (i>(n+1)/2 && i<n && m==n)
                {
                    Console.Write(new String('.', n - i) + new String('*', n - (n - i + n - i)) + new String('.', n - i));
                }
            }
            Console.WriteLine();               
        }
    }
}

