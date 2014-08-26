using System;
using System.Collections.Generic;

class LettersSymbolsNumbers
{
    static void Main()
    {        
        int n = int.Parse(Console.ReadLine());
        string sequenceStr = String.Empty;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            sequenceStr = sequenceStr + input;
        }

        List<char> sequence = new List<char>();
        sequenceStr = sequenceStr.ToUpper();

        for (int i = 0; i < sequenceStr.Length; i++)
        {
            sequence.Add(sequenceStr[i]);
        }

        long lettersSum = 0;
        long numbersSum = 0;
        long symbolsSum = 0;
        
        foreach (char item in sequence)
        {          
            if (item > 64 && item < 91)
            {
                lettersSum = lettersSum + (item - 64) * 10;
            }
            if (item>47 && item <58)
            {
                numbersSum = numbersSum + (item - 48) * 20;
            }              
            if (item>255 || (item>32 && item<48) || (item>57 && item<65) || (item>90 && item<97) || (item>122 && item<256))
            {
                symbolsSum = symbolsSum + 200;
            }                                                   
        }

        Console.WriteLine(lettersSum);
        Console.WriteLine(numbersSum);
        Console.WriteLine(symbolsSum);
    }
}