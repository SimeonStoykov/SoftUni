using System;

class DoubleDowns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rightCounter = 0;
        int leftCounter = 0;
        int verticalCounter = 0;
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int bits = 0; bits < 32; bits++)
            {               
                int lastBit5 = numbers[i] >> bits & 1;
                int lastBit6 = numbers[i + 1] >> bits - 1 & 1;
                if (lastBit5 == 1 && lastBit5 == lastBit6)
                {
                    rightCounter++;
                }

                int lastBit3 = numbers[i] >> bits & 1;
                int lastBit4 = numbers[i + 1] >> bits + 1 & 1;
                if (lastBit3 == 1 && lastBit3 == lastBit4)
                {
                    leftCounter++;
                }

                int lastBit1 = numbers[i] >> bits & 1;
                int lastBit2 = numbers[i + 1] >> bits & 1;
                if (lastBit1 == 1 && lastBit1 == lastBit2)
                {
                    verticalCounter++;
                }              
            }
        }

        Console.WriteLine(rightCounter);
        Console.WriteLine(leftCounter);        
        Console.WriteLine(verticalCounter);
    }
}