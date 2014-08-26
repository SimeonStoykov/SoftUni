using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if ((a>b && a>c) ||(a>b && a==c) || (a>c && a==b))
        {
            Console.WriteLine("The biggest is: " + a);
        }
        else if ((b > a && b > c) || (b > a && b == c) || (b > c && b == a))
        {
            Console.WriteLine("The biggest is: " + b);
        }
        else if ((c > a && c > b) || (c > a && c == b) || (c > b && c == a))
        {
            Console.WriteLine("The biggest is: " + c);
        }
        else
        {
            Console.WriteLine("The biggest is: " + a);
        }
    }
}

