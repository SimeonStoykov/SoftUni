using System;

class NullValue
{
    static void Main()
    {
        int? first = 5;
        double? second = 10;
        Console.WriteLine(first + " " + second);
        first = null;
        second = 5 + null;
        Console.WriteLine(first + " " + second);           
    }
}

