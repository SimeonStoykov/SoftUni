using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();
        string[] removeNames = Console.ReadLine().Split();
        List<string> first = new List<string>();
        List<string> second = new List<string>();

        for (int i = 0; i < names.Length; i++)
        {
            first.Add(names[i]);
        }

        for (int i = 0; i < removeNames.Length; i++)
        {
            first.Remove(removeNames[i]);
        }

        foreach (var name in first)
        {
            Console.Write(name + " ");
        }

        Console.WriteLine();           
    }
}

