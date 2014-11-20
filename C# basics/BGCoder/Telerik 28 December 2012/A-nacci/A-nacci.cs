using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int firstLetter = Convert.ToInt32(char.Parse(Console.ReadLine())) - 64;
        int secondLetter = Convert.ToInt32(char.Parse(Console.ReadLine())) - 64;
        int rows = int.Parse(Console.ReadLine());
        int nextLetter = 0;
        char nextChar;
        int spacesCount = 1;

        char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G','H', 'I', 'J', 'K', 'L', 'M',
                           'N', 'O', 'P','Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        if (rows == 1)
        {
            char first = letters[firstLetter - 1];
            Console.WriteLine(first);
        }
        else
        {
            char first = letters[firstLetter - 1];
            char second = letters[secondLetter - 1];
            Console.WriteLine(first);
            Console.Write(second);
        }

        for (int i = 0; i < (rows - 2) * 2 + 1; i++)
        {
            nextLetter = firstLetter + secondLetter;

            if (nextLetter > 26)
            {
                nextLetter = nextLetter % 26;
            }

            nextChar = letters[nextLetter - 1];

            if (i == 0)
            {
                Console.WriteLine(nextChar);
            }
            else if (i != 0 && i%2 == 0)
            {
                for (int spaces = 0; spaces < spacesCount; spaces++)
                {
                    Console.Write(" ");
                }
                spacesCount++;
                Console.Write(nextChar);
                Console.WriteLine();
            }
            else
            {
                Console.Write(nextChar);
            }

            firstLetter = secondLetter;
            secondLetter = nextLetter;
        }     
    }
}