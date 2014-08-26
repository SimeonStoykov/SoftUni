using System;

class BitsExchange
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Number: ");
            uint number = uint.Parse(Console.ReadLine());

            // Set positions
            int[] position1 = { 3, 4, 5 };
            int[] position2 = { 24, 25, 26 };
            if (position1.Length != position2.Length)
            {
                Console.WriteLine("The positions should've an equal length");
                return;
            }

            for (int i = position1.Length - 1; i >= 0; i--) // position1.Length is 3 but arrays start from 0
            {
                // Getting the first bit
                uint tempBit = number >> position1[i];
                tempBit = tempBit & 1;

                // Getting the second bit
                uint secondTempBit = number >> position2[i];
                secondTempBit = secondTempBit & 1;

                // Placing the first bit into the position of the second
                if (tempBit == 0)
                {
                    int mask = ~(1 << position2[i]);
                    number = number & (uint)mask;
                }
                else if (tempBit == 1)
                {
                    int mask = 1 << position2[i];
                    number = number | (uint)mask;

                }

                // Placing the first bit into the position of the second
                if (secondTempBit == 0)
                {
                    int mask = ~(1 << position1[i]);
                    number = number & (uint)mask;
                }
                else if (secondTempBit == 1)
                {
                    int mask = 1 << position1[i];
                    number = number | (uint)mask;

                }
            }
            Console.WriteLine(number);
        }
    }
}