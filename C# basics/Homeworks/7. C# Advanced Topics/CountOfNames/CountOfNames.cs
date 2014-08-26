using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();
        List<string> namesList = names.ToList<string>();
        namesList.Sort();
        Dictionary<string, int> countNames = new Dictionary<string, int>();

        foreach (var name in namesList)
        {
            if (countNames.ContainsKey(name))
            {
                countNames[name] = countNames[name] + 1;
            }
            else
            {
                countNames[name] = 1;
            }
        }

        foreach (var item in countNames)
        {           
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}

