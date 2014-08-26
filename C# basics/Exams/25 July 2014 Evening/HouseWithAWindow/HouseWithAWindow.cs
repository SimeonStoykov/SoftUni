using System;

class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = (2 * n) - 1;
        int outerDots = (width - 1) / 2;
        int innerDots = 1;
                
        for (int rows = 1; rows < n+1; rows++)
        {           
            if (rows==1)
            {
                Console.WriteLine(new String('.', outerDots) + new String('*', 1) + new String('.', outerDots));
                outerDots--;
            }
            else                                         
            {
                Console.WriteLine(new String('.', outerDots) + new String('*', 1) + new String('.', innerDots) 
                                + new String('*', 1) + new String('.', outerDots));
                outerDots--;
                innerDots += 2;
            }                                                                        
        }

        Console.WriteLine(new String('*', width));

        for (int i = 1; i <= n/4; i++)
        {
            Console.WriteLine(new String('*', 1) + new String('.', width-2) + new String('*', 1));
        }
        for (int i = 1; i <= n/2; i++)
        {                       
           Console.WriteLine(new String('*', 1) + new String('.', n/2) + new String('*', n-3)+ new String('.', n/2) 
                           + new String('*', 1));            
        }
        for (int i = 1; i <= n/4; i++)
        {
            Console.WriteLine(new String('*', 1) + new String('.', width - 2) + new String('*', 1));
        }

        Console.WriteLine(new String('*', width));
    }
}