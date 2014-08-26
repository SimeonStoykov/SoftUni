using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger sum = first+second+third;

        if (n == 1)
            Console.WriteLine(first);
        else if (n == 2)
            Console.WriteLine(second);
        else if (n == 3)
            Console.WriteLine(third);
        else
        {
            for (int i = 1; i <= n - 4; i++)
            {
                first = second;
                second = third;
                third = sum;
                sum = first + second + third;
            }
            Console.WriteLine(sum);
        }                                            
    }
}

