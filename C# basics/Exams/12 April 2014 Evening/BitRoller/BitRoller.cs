using System;

class BitRoller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        char[] bits = Convert.ToString(n, 2).PadLeft(19, '0').ToCharArray();

        int freezingPosition = 19-1-f;

        for (int i = 0; i < r; i++)
        {
            char[] newBits = new char[bits.Length];

            for (int checkBits = 0; checkBits < bits.Length; checkBits++)
            {
                if (freezingPosition==checkBits)
                {
                    newBits[checkBits]=bits[checkBits];
                }
                else
                {
                    int newPos = (checkBits + 1) % bits.Length;
                    if (newPos==freezingPosition)
                    {
                        newPos = (newPos + 1) % bits.Length;
                    }
                    newBits[newPos] = bits[checkBits];
                }
            }

            for (int j = 0; j < bits.Length; j++)
            {
                bits[j] = newBits[j];
            }
        }
        int result = Convert.ToInt32(new String(bits), 2);
        Console.WriteLine(result);                      
    }
}

