using System;

class TripleRotationOfDigits
{
    static void Main()
    {
        string number = Console.ReadLine();
        string rotatedNumber = String.Empty;

        if (number.Length >= 3)
        {
            for (int i = number.Length - 1; i >= number.Length - 3; i--)
            {
                if (number[i] != '0')
                {
                    rotatedNumber = number[i] + rotatedNumber;
                }
            }

            for (int i = 0; i < number.Length - 3; i++)
            {
                rotatedNumber += number[i];
            }
        }
        else if (number.Length == 2)
        {
            for (int i = 0; i < 2; i++)
            {
                if (number[i] != '0')
                {
                    rotatedNumber = number[i] + rotatedNumber;
                }
            }
        }
        else
        {
            rotatedNumber = number;
        }
                     
        Console.WriteLine(rotatedNumber);
    }
}