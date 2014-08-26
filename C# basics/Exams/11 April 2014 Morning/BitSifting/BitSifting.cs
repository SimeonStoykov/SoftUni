using System;

class BitSifting
{
    static void Main()
    {
        long numberToSieve = long.Parse(Console.ReadLine());
        int numberOfSieves = int.Parse(Console.ReadLine());

        for (int i = 1; i <=numberOfSieves; i++)
        {
            long sieves = long.Parse(Console.ReadLine());           
            numberToSieve = numberToSieve & ~sieves;            
        }

        string bits = Convert.ToString(numberToSieve, 2);
        int counter = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            if (bits[i] == '1')
            {
                counter++;
            }
        }

        Console.WriteLine(counter);           
    }
}

