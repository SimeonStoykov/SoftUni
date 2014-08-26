using System;

class Illuminati
{
    static void Main()
    {
        string input = Console.ReadLine();
            
        int countA = 0;

        foreach (char c in input)
        {
            if (c == 'a' || c == 'A')
            {
                countA++;
            }
        }

        int countE = 0;

        foreach (char c in input)
        {
            if (c == 'e' || c == 'E')
            {
                countE++;
            }
        }

        int countI = 0;

        foreach (char c in input)
        {
            if (c == 'i' || c == 'I')
            {
                countI++;
            }
        }

        int countO = 0;

        foreach (char c in input)
        {
            if (c == 'o' || c == 'O')
            {
                countO++;
            }
        }

        int countU = 0;

        foreach (char c in input)
        {
            if (c == 'u' || c=='U')
            {
                countU++;
            }
        }

        int countVowels = countA+countE+countI+countO+countU;
        int sumVowels = countA * 65 + countE * 69 + countI * 73 + countO * 79 + countU * 85;
        Console.WriteLine(countVowels + "\n" + sumVowels);           
    }
}

