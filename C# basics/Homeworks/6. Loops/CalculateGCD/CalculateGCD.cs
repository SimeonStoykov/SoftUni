using System;

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int dividend  = 0;
        int divisor=0;
        if (a>=b)
        {
            dividend = a;
            divisor = b;
        }
        else
        {
            dividend = b;
            divisor = a;
        }

        while (true)
        {
            int remainder = dividend % divisor;
            int quotient = dividend / divisor;
            if (remainder != 0)
            {
                dividend = divisor;
                divisor = remainder;
            }
            else
            {
                break;
            }         
        }
                                                
        Console.WriteLine(divisor);
    }
}

