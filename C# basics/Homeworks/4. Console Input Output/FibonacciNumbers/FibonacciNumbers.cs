using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int first = 0;
        int second = 1;
            
        if (n==1)
        {
            Console.WriteLine(first);
        }
        else if (n==2)
        {
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
        else
        {
            Console.WriteLine(first);
            Console.WriteLine(second);

            for (int i = 1; i <= n-2; i++)
            {                                       
                int sum = first + second;
                Console.WriteLine(sum);
                first = second;
                second = sum;                    
            }
        }            
    }
}

