using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int GetPBit = n >> p;
        int bit = GetPBit & 1;
        bool isOne = false;
        if (bit==1)
        {
            isOne = true;
        }
        Console.WriteLine(isOne);
    }
}

