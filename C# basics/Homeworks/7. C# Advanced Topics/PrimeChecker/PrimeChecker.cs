using System;

class PrimeChecker
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine(isPrime(n));
    }

    static bool isPrime(long n)
    {
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n%i==0)
            {
                isPrime = false;                                      
                break;
            }              
        }
        if (n < 2)
        {
            isPrime = false;
        }
        return isPrime;
    }
}
