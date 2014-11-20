using System;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string input = Console.ReadLine();
        int oddSum = 0;
        int counter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 != 0 && char.IsDigit(input[i]))
            {
                oddSum += input[i] - '0';
                counter++;
            }
        }

        Console.WriteLine(counter + " " + oddSum);
    }
}