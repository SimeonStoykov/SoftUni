using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class BullsAndCows
{
    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine()); 
        int bulls = int.Parse(Console.ReadLine()); 
        int cows = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int guessNumber = 1111; guessNumber <= 9999; guessNumber++)
        {
            int bullsFound = GetBulls(secretNumber, guessNumber);
            int cowsFound = GetCows(secretNumber, guessNumber);
            string guessStr = guessNumber.ToString();
            Regex r = new Regex("0");
            if (!r.IsMatch(guessStr) && bulls == bullsFound && cows == cowsFound)
            {
                Console.Write(guessNumber + " ");
                counter++;
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int GetCows(int secretNumber, int guessNumber)
    {
        int cows = 0;

        string secretNumberStr = secretNumber.ToString();
        string guessNumberStr = guessNumber.ToString();

        List<char> secretList = new List<char>();
        List<char> guessList = new List<char>();

        for (int i = 0; i < secretNumberStr.Length; i++)
        {
            secretList.Add(secretNumberStr[i]);
        }

        for (int i = 0; i < guessNumberStr.Length; i++)
        {
            guessList.Add(guessNumberStr[i]);
        }

        for (int i = 0; i < 4; i++)
        {
            if (secretList[i] == guessList[i])
            {
                secretList[i] = '*';
                guessList[i] = '*';
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (secretList[i]!='*' && secretList[i] == guessList [j])
                {
                    cows++;
                    secretList[i] = '*';
                    guessList[j] = '*';
                }
            }
        }
        return cows;
    }
     
    private static int GetBulls(int secretNumber, int guessNumber)
    {
       int bulls = 0;

       string secretNumberStr = secretNumber.ToString();
       string guessNumberStr = guessNumber.ToString();

       List<char> secretList = new List<char>();
       List<char> guessList = new List<char>();

       for (int i = 0; i < secretNumberStr.Length; i++)
       {
           secretList.Add(secretNumberStr[i]);
       }

       for (int i = 0; i < guessNumberStr.Length; i++)
       {
           guessList.Add(guessNumberStr[i]);
       }

       for (int i = 0; i < 4; i++)
       {
           if (secretList[i] == guessList[i])
           {
               bulls++;
           }
       }
       return bulls;
    }
}