using System;
using System.Collections.Generic;

public class Itemset : List<long>
{
}

public class ItemsetCollection : List<Itemset>
{
}
class SubsetSums
{
    static void Main()
    {
        long searchedSum = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        Itemset i1 = new Itemset();

        for (int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            i1.Add(number);
        }

        foreach (var item in FindAllSubsets(i1))
        {
            long currentSubsetSum = 0;
            long [] currentSubset = item.ToArray();
            if (currentSubset.Length != 0)
            {
                foreach (var number in currentSubset)
                {
                    currentSubsetSum += number;
                }
                if (currentSubsetSum == searchedSum)
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);       
    }

    public static ItemsetCollection FindAllSubsets(Itemset itemset)
    {
        ItemsetCollection allSubsets = new ItemsetCollection();

        int subsetCount = (int)Math.Pow(2, itemset.Count);
        for (int i = 0; i < subsetCount; i++)
        {
            Itemset subset = new Itemset();
            for (int bitIndex = 0; bitIndex < itemset.Count; bitIndex++)
            {
                if (GetBit(i, bitIndex) == 1)
                {
                    subset.Add(itemset[bitIndex]);
                }
            }

            allSubsets.Add(subset);
        }

        return (allSubsets);
    }

    public static int GetBit(int value, int position)
    {
        int bit = value & (int)Math.Pow(2, position);
        return (bit > 0 ? 1 : 0);
    }
}