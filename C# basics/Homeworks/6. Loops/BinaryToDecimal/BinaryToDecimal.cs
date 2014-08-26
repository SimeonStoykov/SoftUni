using System;

class BinaryToDecimal
{
    static void Main()
    {
        string numberStr = Console.ReadLine();
        int[] numbersArray = new int[numberStr.Length];

        for (int i = 0; i < numberStr.Length; i++)
        {
            numbersArray[i] = Convert.ToInt32(numberStr[i].ToString());
        }

        int power = numberStr.Length - 1;
        long numberDec = 0;

        for (int i = 0; i < numberStr.Length; i++)
        {
            numberDec = numberDec + numbersArray[i] * (int)Math.Pow(2, power);
            power--;
        }

        Console.WriteLine(numberDec);           
    }
}

