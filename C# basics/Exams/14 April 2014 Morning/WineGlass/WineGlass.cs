using System;

class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDotCount = 1;
        int asteriksCount = n - 4;

        for (int i = 1; i <=n/2; i++)
		{
            if (i==1)
            {
                Console.WriteLine('\\' + new string('*', n-2) +'/'  );
            }
            if (i>1 && i<=n/2)
            {                  
                Console.WriteLine(new String('.', outerDotCount) + '\\' + new string('*', asteriksCount) + '/' 
                                + new String('.', outerDotCount));
                outerDotCount++;        
                asteriksCount =asteriksCount-2;                   
            }                           
		}

        for (int i = 1; i <= n/2; i++)
        {
            if (n>=12)
            {
                if (i>=1 && i<=(n/2)-2)
                {
                    Console.WriteLine(new String('.', (n/2)-1) + "||" + new String('.', (n/2)-1));
                }
                else
                {
                    Console.WriteLine(new String('-', n));
                }
            }
            if (n < 12)
            {
                if (i >= 1 && i <= (n / 2) - 1)
                {
                    Console.WriteLine(new String('.', (n / 2) - 1) + "||" + new String('.', (n / 2) - 1));
                }
                else
                {
                    Console.WriteLine(new String('-', n));
                }
            }
        }            
    }
}