using System;
using System.Collections.Generic;

class LongestNonDecreasingSubsequence
{
    static void Main()
    {                                 
        string[] numbersStr = Console.ReadLine().Split();
        List<int> numbers = new List<int>();
        List<int> sequence = new List<int>();
        List<int> maxSequence = new List<int>();

        for (int i = 0; i < numbersStr.Length; i++)
        {
            numbers.Add(int.Parse(numbersStr[i]));
        }

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            int current = numbers[i];
            sequence.Add(numbers[i]);

            for (int j = i; j < numbers.Count - 1; j++)
            {

                if (current <= numbers[j + 1])
                {
                    sequence.Add(numbers[j + 1]);
                    current = numbers[j + 1];
                }
            }

            if (sequence.Count > maxSequence.Count)
            {
                maxSequence = new List<int>();
                maxSequence.Add(sequence[0]);
                for (int k = 0; k < sequence.Count - 1; k++)
                {
                    if (sequence[k] <= sequence[k + 1])
                    {
                        maxSequence.Add(sequence[k + 1]);
                    }
                    numbers.Remove(sequence[k + 1]);
                }
            }
            sequence = new List<int>();
        }

        for (int i = 0; i < maxSequence.Count; i++)
        {
            Console.Write(maxSequence[i] + " ");
        }
    }
}
