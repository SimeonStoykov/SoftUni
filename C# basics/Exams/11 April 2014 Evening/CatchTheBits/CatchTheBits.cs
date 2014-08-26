using System;

class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int index = 0;
        int bitsCount = 0;
        int outputBits = 0;

        for (int i = 1; i <=n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int bits = 7; bits >= 0; bits--)
            {
                if ((step==1 && index>0) || (index%step==1))
                {
                    int bitValue= (number >> bits) & 1;
                    outputBits = outputBits << 1;
                    outputBits = outputBits | bitValue;
                    bitsCount++;

                    if (bitsCount == 8)
                    {
                        Console.WriteLine(outputBits);
                        outputBits = 0;
                        bitsCount = 0;
                    }
                }
                index++;
            }                               
        }

        if (bitsCount > 0)
        {
            outputBits = outputBits << (8-bitsCount);
            Console.WriteLine(outputBits);
        }           
    }
}

