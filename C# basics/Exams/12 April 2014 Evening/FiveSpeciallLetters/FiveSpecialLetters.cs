using System;
using System.Collections.Generic;

class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        Dictionary<char, int> values = new Dictionary<char, int> {{'a',5}, {'b',-12}, {'c',47}, {'d',7}, {'e',-32}};
        int resultsCount = 0;
        for (char i1 = 'a'; i1 <= 'e'; i1++)
        {
            for (char i2 = 'a'; i2 <= 'e'; i2++)
            {
                for (char i3 = 'a'; i3 <= 'e'; i3++)
                {
                    for (char i4 = 'a'; i4 <= 'e'; i4++)
                    {
                        for (char i5 = 'a'; i5 <= 'e'; i5++)
                        {
                            string word =i1.ToString() + i2 + i3 + i4 + i5;
                            string weightWord=""+i1;

                            foreach (var character in word)
                            {
                                if (!weightWord.Contains(character.ToString()))
                                {
                                    weightWord += character;
                                }
                            }

                            long currentWeight = CalcWeight(weightWord, values);
                                
                            if (currentWeight >= start && currentWeight <= end)
                            {                                  
                                Console.Write(word + " ");
                                resultsCount++;
                            }                                
                        }
                    }
                }
            }
        }

        if (resultsCount == 0)
        {
            Console.Write("No");
        }
    }

    static long CalcWeight(string weightWord, Dictionary<char, int> values)
    {
        long weight = 0;
        int multiplier = 1;

        foreach (var currentChar in weightWord)
        {
            weight += multiplier * values[currentChar];
            multiplier++;
        }

        return weight;
    }       
}

