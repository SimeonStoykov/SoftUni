using System;

class AstrologicalDigits
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sumOfDigits = 0;

        for (int i = 0; i < input.Length; i++)
        {           
            if (char.IsDigit(input[i]))
            {
                sumOfDigits += input[i] - 48;
            }
        }

        if (sumOfDigits > 9)
        {
            while (sumOfDigits > 9)
            {
                string newDigits = sumOfDigits.ToString();
                sumOfDigits = 0;
                for (int i = 0; i < newDigits.Length; i++)
                {
                    sumOfDigits += newDigits[i] - 48;
                }
            }
        }
        
        Console.WriteLine(sumOfDigits);
    }
}