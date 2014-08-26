using System;

class BitKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        int sequence = 0;
        int bitsCount = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            for (int bits = 7; bits>=0; bits--)
            {
                if (!((index % step == 1) || (step == 1 && index > 0)))
                {
                    int firstBit = currentNumber>>bits & 1 ;
                    sequence = sequence << 1;
                    sequence = sequence | firstBit;
                    bitsCount++;
                    if (bitsCount == 8)
                    {
                        Console.WriteLine(sequence);
                        sequence = 0;
                        bitsCount = 0;
                    }
                }
               index++;                
            }                                             
        }

        if (bitsCount > 0)
        {
            sequence = sequence << (8 - bitsCount);
            Console.WriteLine(sequence);
        }
    }
}

