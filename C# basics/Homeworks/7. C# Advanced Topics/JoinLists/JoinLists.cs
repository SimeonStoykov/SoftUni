using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        string[] second = Console.ReadLine().Split();
        List<int> firstNums = new List<int>();
        List<int> secondNums = new List<int>();

        for (int i = 0; i < first.Length; i++)
        {
            firstNums.Add(int.Parse(first[i]));
        }

        for (int i = 0; i < second.Length; i++)
        {
            secondNums.Add(int.Parse(second[i]));
        }

        List<int> ulist = firstNums.Union(secondNums).ToList();  //Joining two lists without diplicates
        ulist.Sort();

        foreach (var item in ulist)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

