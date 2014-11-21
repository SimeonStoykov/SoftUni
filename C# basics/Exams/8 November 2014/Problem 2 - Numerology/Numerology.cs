using System;

class Numerology
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string[] birthDate = input[0].Split('.');

        int day = int.Parse(birthDate[0]);
        int month = int.Parse(birthDate[1]);
        int year = int.Parse(birthDate[2]);

        long birthProduct = day * month * year;

        if (month % 2 != 0)
        {
            birthProduct *= birthProduct;
        }

        int lettersSum = 0;

        for (int i = 0; i < input[1].Length; i++)
        {
            if (input[1][i] >= 'a' && input[1][i] <= 'z')
            {
                lettersSum += input[1][i] - 96;
            }
            else if (input[1][i] >= 'A' && input[1][i] <= 'Z')
            {
                lettersSum += 2 * (input[1][i] - 64);
            }
            else if (input[1][i] >= '0' && input[1][i] <= '9')
            {
                lettersSum += input[1][i] - 48;
            }
        }

        long totalSum = birthProduct + lettersSum;
        long digitsSum = 0;

        if (totalSum > 13)
        {
            while (true)
            {
                while (totalSum > 0)
                {
                    digitsSum += totalSum % 10;
                    totalSum /= 10;
                }
                if (digitsSum <= 13)
                {
                    Console.WriteLine(digitsSum);
                    break;
                }
                totalSum = digitsSum;
                digitsSum = 0;
            }                                       
        }
        else
        {
            Console.WriteLine(totalSum);
        }
    }
}