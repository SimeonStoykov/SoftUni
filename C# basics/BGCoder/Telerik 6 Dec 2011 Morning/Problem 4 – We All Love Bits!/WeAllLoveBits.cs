using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
 
        for (int i = 0; i < n; i++)
        {
            int P = int.Parse(Console.ReadLine());
            int invertedP = 0;
            int reversedP = 0;

            int bitsCount = GetBitsCount(P);

            for (int bit = 0; bit < bitsCount; bit++)
            {
                int currentBit = (P & (1 << bit)) >> bit;
                if (currentBit == 1)
                {
                    invertedP = invertedP & ~(1 << bit);
                }
                else
                {
                    invertedP = invertedP | (1 << bit);
                }
            }

            for (int bit = 0; bit < bitsCount; bit++)
            {
                int currentBit = (P & (1 << bit)) >> bit;
                reversedP = reversedP << 1;
                reversedP = reversedP | currentBit;                
            }

            int pNew = (P ^ invertedP) & reversedP;
            Console.WriteLine(pNew);
        }

    }

    private static int GetBitsCount(int P)
    {
        int bitsCounter = 0;
        for (int bit = 31; bit >= 0; bit--)
        {
            int currentBit = (P & (1 << bit)) >> bit;
            if (currentBit == 1)
            {
                bitsCounter = bit + 1;
                break;
            }
        }
        return bitsCounter;
    }
}