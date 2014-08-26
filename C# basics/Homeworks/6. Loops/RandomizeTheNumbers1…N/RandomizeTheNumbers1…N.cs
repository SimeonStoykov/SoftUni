using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        int val = 0;
        Random r = new Random();
        int IntialCount = 1;
        int n = int.Parse(Console.ReadLine());
            
        while (IntialCount <= n)
        {               
            val = r.Next(1, n+1);
            if (!list.Contains(val))
            {
                list.Add(val);
                IntialCount++;
            }
        }

        foreach (int number in list)
        {
            Console.Write(number + " ");                                
        }

        Console.WriteLine();
    }
}

