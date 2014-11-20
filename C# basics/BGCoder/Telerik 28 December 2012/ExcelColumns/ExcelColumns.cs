using System;
using System.Collections.Generic;

class ExcelColumns
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<char> letters = new List<char>();
        long index = 0;

        for (int i = 0; i < N; i++)
        {
            letters.Add(char.Parse(Console.ReadLine()));
        }

        int power = letters.Count - 1;
        for (int i = 0; i < letters.Count; i++)
        {
            index += (letters[i] - (long)64) * (long)Math.Pow(26, power);
            power--;
        }

        Console.WriteLine(index);
    }
}