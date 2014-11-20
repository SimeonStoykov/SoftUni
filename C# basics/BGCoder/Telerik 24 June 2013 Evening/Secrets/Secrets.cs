using System;
using System.Linq;

class Secrets
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input[0]=='-')
        {
            input = input.Remove(0, 1);
        }
        string reversed = "";                           

        for (int i = 0; i < input.Length; i++)
        {
            reversed = input[i] + reversed;
        }

        int sum = 0;
        int position = 0;

        for (int i = 0; i < reversed.Length; i++)
        {
            position++;
            if (i % 2 == 0)    //odd
            {
                sum += int.Parse(reversed.Substring(i, 1)) * (int)Math.Pow(position, 2);
            }
            else //even
            {
                sum += (int)Math.Pow(int.Parse(reversed.Substring(i, 1)), 2) * position;
            }
        }

        Console.WriteLine(sum);

        char[] sequenceChars = new char[sum % 10];
        int R = sum % 26;
        int firstLetter = 64 + R + 1;

        if (sum % 10 == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", input);
        }
        else
        {
            for (int i = 0; i < sequenceChars.Length; i++)
            {
                sequenceChars[i] = (char)(firstLetter);
                firstLetter++;
                if (firstLetter == 91)
                {
                    firstLetter = 65;
                }
            }
        }

        foreach (var character in sequenceChars)
        {
            Console.Write(character);
        }
        Console.WriteLine();
    }
}