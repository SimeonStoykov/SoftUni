using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftDots = -1;
        int rightDots = n;

        for (int row = 1; row <= 2 * n - 1; row++)
        {            
            if (row > n)
            {              
                leftDots--;                
                rightDots++;        
            }
            else
            {
                leftDots++;
                rightDots--;
            }
            Console.WriteLine("{0}*{1}", new String('.', leftDots), new String('.', rightDots));            
        }
    }
}