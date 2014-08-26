using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char star = '*';
        char dash = '-';
        int lowerNumber = (n+1) / 2;
        int upperNumber = (n+1) / 2;

        for (int i = 1; i <= n; i++)
        {
            if (i>1 && i<=(n+1)/2)
            {
                lowerNumber--;
                upperNumber++;
            }
            if (i > (n + 1) / 2 && i < n)
            {
                lowerNumber++;
                upperNumber--;
            }    
                     
            for (int j = 1; j <=n; j++)
            {
                if ((i==1 || i==n )&& j==n)
                {
                    Console.Write(new String(dash, n / 2) + star + new String(dash, n / 2));
                }                    
                if (i>1 && i<n && (j==lowerNumber||j==upperNumber))
                {
                    Console.Write(star);
                }                   
                if (i > 1 && i < n  && j != lowerNumber && j!=upperNumber)
                {
                    Console.Write(dash);
                }              
            }

            Console.WriteLine();                                
        }
    }              
}          