using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int count = 0;

        if (n < m)
        {
            for (int i = n; i <= m; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
        }
        else if (n > m)
        {
            for (int i = m; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
        }
           
        Console.WriteLine(count);          
    }
}

