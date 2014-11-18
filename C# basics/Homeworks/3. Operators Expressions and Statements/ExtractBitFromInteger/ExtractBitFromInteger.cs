using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int GetPBit = n >> p;
        int bit = GetPBit & 1;
        Console.WriteLine(bit);
    }
}