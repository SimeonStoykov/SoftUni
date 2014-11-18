using System;

class ThirdDigit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isThird7 = false;
        int divideBy100 = n / 100;

        if (divideBy100 % 10 == 7)
        {
            isThird7 = true;
        }
        Console.WriteLine(isThird7);            
    }
}