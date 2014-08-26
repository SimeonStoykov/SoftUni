using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = a;

        if (a>b)
        {
            a = b;
            b = c;
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.WriteLine("First is not bigger than second");
        }
    }
}

