using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());            
        Console.WriteLine(Fib(n));
    }

    static int Fib(int n)
    {
        int first = 1;
        int second = 1;
        int third = 0;

        for (int i = 0; i <= n - 2; i++)
        {
            third = first + second;
            first = second;
            second = third;
        }
        if (n>1)
        {
            return third;
        }
        else
        {
            return 1;
        }            
    }
}

