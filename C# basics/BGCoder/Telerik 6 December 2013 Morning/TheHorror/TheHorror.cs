using System;
using System.Numerics;

class TheHorror
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] digits = input.ToCharArray();
        BigInteger digitsSum = 0;
        int digitsAtEvenPosition = 0;

        for (int i = 0; i < digits.Length; i++)
        {
            //the text can have not only digits (it can have letters or another symbols)
            if (i % 2 == 0 && char.IsDigit(digits[i])) 
            {
                digitsSum += digits[i] - 48;
                digitsAtEvenPosition++;
            }
        }

        Console.WriteLine("{0} {1}", digitsAtEvenPosition, digitsSum);
    }
}