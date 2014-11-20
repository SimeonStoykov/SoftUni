using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int bit = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            uint number = uint.Parse(Console.ReadLine());
            int counter = 0;
            int loopCounter = 0;

            for (int position = 31; position >= 0; position--)
            {
                uint bitAtPosition = (number & ((uint)1 << position)) >> position;
                if (bitAtPosition == 1)
                {
                    loopCounter = position;
                    break;
                }
            }

            for (int checkedBit = 0; checkedBit <= loopCounter; checkedBit++)
            {
                uint currentBit = (number & ((uint)1 << checkedBit)) >> checkedBit;
                if (currentBit == bit)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}