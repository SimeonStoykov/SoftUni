using System;

class ExtractBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int GetPBit = n >> p;
        int bit = GetPBit & 1;
        Console.WriteLine(bit);
    }
}