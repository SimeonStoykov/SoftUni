using System;

class Pillars
{
    static void Main()
    {
        int[] numbers = new int[8];
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int leftOnes = 0;
        int rightOnes = 0;

        for (int pillar = 7; pillar >= 0; pillar--)
        {
            for (int row = 0; row < numbers.Length; row++)
            {
                for (int col = pillar + 1; col < 8; col++) //left part
                {
                    int currentBit = (numbers[row] & (1 << col)) >> col;
                    if (currentBit == 1)
                    {
                        leftOnes++;
                    }
                }
                for (int col = 0; col < pillar; col++) //right part
                {
                    int currentBit = (numbers[row] & (1 << col)) >> col;
                    if (currentBit == 1)
                    {
                        rightOnes++;
                    }
                }
            }

            if (leftOnes == rightOnes)
            {
                Console.WriteLine(pillar);
                Console.WriteLine(leftOnes);
                counter++;
                break;
            }
            leftOnes = 0;
            rightOnes = 0;
        }

        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}