using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int  upperNumber = (n + 1) / 2;
        int lowerNumber = (n + 1) / 2;

        for (int i = 1; i <= n/2; i++)
        {                
            for (int j = 1; j <= n; j++)
            {
                if (j==lowerNumber || j==upperNumber)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            upperNumber++;
            lowerNumber--;
       }

       for (int i = 1; i <=(n/2)+1; i++)
        {
            if (i==1)
            {
                Console.WriteLine(new String('*', n));
            }
            if (i==n/2+1)
            {
                Console.WriteLine(new String('.', n / 4) +new String('*', n-(n / 4+n/4))+ new String('.', n / 4));
            }
            if (i!=n/2+1 && i!=1)
            {
                Console.WriteLine(new String('.', n / 4) + '*' + new String('.', n - (n / 4 + n / 4 + 2)) + '*' 
                                + new String('.', n / 4));                    
            }                
        }
    }
}