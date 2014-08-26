/*Calculate N! / (K! * (N-K)!)*/
using System;
using System.Numerics;

class Problem7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        int factorialNumber = n - k;
        BigInteger downFactorial = 1;

        for (int i = k + 1; i <= n; i++)
        {
            factorial *= i;

        }

        for (int j = 1; j <= factorialNumber; j++)
        {
            downFactorial *= j;
        }

        Console.WriteLine(factorial/downFactorial);
    }
}
