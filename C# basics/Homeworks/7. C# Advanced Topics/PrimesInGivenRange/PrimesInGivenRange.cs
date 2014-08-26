using System;
using System.Collections.Generic;
using System.Linq;

class PrimesInGivenRange
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        PrintPrimes(FindPrimesInRange, startNum, endNum);
    }

    static void PrintPrimes(Func<int, int, List<int>> FindPrimesInRange, int startNum, int endNum)
    {
        List<int> primes = FindPrimesInRange(startNum, endNum);
        foreach (var prime in primes)
        {
            if (prime==primes.Last())
            {
                Console.Write(prime);
            }
            else
            {
                Console.Write(prime + ", ");
            }              
        }
        Console.WriteLine();
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            primes.Add(i);
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    primes.Remove(i);
                    break;
                }
            }
            if (i < 2)
            {
                primes.Remove(i);
            }
        }
        return primes;
    }
}

