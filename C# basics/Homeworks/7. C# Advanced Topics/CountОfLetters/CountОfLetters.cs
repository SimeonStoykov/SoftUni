using System;
using System.Collections.Generic;
using System.Linq;

class CountОfLetters
{
    static void Main()
    {
        string[] letters = Console.ReadLine().Split();
        List<string> characters = letters.ToList<string>();
        characters.Sort();
        var occurances = new Dictionary<string, int>();

        foreach (var c in characters)
        {
            if (occurances.ContainsKey(c))
                occurances[c] = occurances[c] + 1;
            else
                occurances[c] = 1;
        }
            
        foreach (var entry in occurances)
        {
            Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
        }
    }
}

