using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class BullsAndCows
{
    const int DIGITS = 4;
    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int guessNumber = 1111; guessNumber <= 9999; guessNumber++)
        {
            int bullsFound = GetBuls(secretNumber, guessNumber);
            int cowsFound = GetCows(secretNumber, guessNumber);
            Regex r = new Regex("0");
            if (!r.IsMatch(guessNumber.ToString()) && bullsFound == bulls && cowsFound == cows)
            {
                Console.Write(guessNumber + " ");
                counter++;
            }
        }

        if (counter == 0)
        {
            Console.Write("No");
        }
    }

    private static int GetBuls(int secretNumber, int guessNumber)
    {
        string secretNum = secretNumber.ToString();
        string guessNum = guessNumber.ToString();
        List<char> secretChars = secretNum.ToList<char>();
        List<char> guessChars = guessNum.ToList<char>();
        int bulls = 0;
        for (int i = 0; i < DIGITS; i++)
        {
            if (secretChars[i] == guessChars[i])
            {
                bulls++;
            }
        }
        return bulls;
    }

    private static int GetCows(int secretNumber, int guessNumber)
    {
        string secretNum = secretNumber.ToString();
        string guessNum = guessNumber.ToString();
        List<char> secretChars = secretNum.ToList<char>();
        List<char> guessChars = guessNum.ToList<char>();
        int cows = 0;
        for (int i = 0; i < DIGITS; i++)
        {
            if (secretChars[i] == guessChars[i])
            {
                secretChars[i] = '*';
                guessChars[i] = '*';
            }
        }

        for (int secretIndex = 0; secretIndex < DIGITS; secretIndex++)
        {
            for (int guessIndex = 0; guessIndex < DIGITS; guessIndex++)
            {
                if (secretChars[secretIndex] != '*' && (secretChars[secretIndex] == guessChars[guessIndex]))
                {
                    cows++;
                    secretChars[secretIndex] = '*';
                    guessChars[guessIndex] = '*';
                }
            }
        }
        return cows;
    }
}



