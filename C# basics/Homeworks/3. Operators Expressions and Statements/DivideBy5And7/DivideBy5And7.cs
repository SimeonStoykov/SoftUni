using System;

class DivideBy5And7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool DivideBy7And5 = false;

        if (n == 0)
        {
            DivideBy7And5 = false;
        }

        else if (n % 7 * 5 == 0)
        {
            DivideBy7And5 = true;
        }

        Console.WriteLine(DivideBy7And5);
    }
}