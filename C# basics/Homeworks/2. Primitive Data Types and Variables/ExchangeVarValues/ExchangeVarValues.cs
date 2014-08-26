using System;

class ExchangeVarValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a={0} b={1}", a, b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("a={0} b={1}", a, b);
    }
}

