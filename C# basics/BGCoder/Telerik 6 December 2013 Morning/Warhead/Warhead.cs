using System;

class Warhead
{
    static void Main()
    {
        string[] binaryNumbers = new string[16];
        int[] numbersForCountingBlocks = new int[16];
        int[] numbers = new int[16];

        for (int i = 0; i < binaryNumbers.Length; i++)
        {
            binaryNumbers[i] = Console.ReadLine();
        }

        for (int i = 0; i < numbersForCountingBlocks.Length; i++)
        {
            numbersForCountingBlocks[i] = Convert.ToInt32(binaryNumbers[i], 2);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(binaryNumbers[i], 2);
        }

        bool disarmedBlue = false;
        bool disarmedRed = false;
        bool capacitorHitted = false;
        bool blueDetonated = false;
        bool redDetonated = false;
        int redBlocks = 0;
        int blueBlocks = 0;
        int maskSeven = 7;
        int maskFive = 5;

        //Counting Red Blocks and clearing each block after it is counted
        for (int row = 0; row <= 16 - 3; row++)
        {
            for (int col = 13; col >= 7; col--)
            {
                if (((maskSeven << col) & numbersForCountingBlocks[row]) >> col == maskSeven
                 && ((maskFive << col) & numbersForCountingBlocks[row + 1]) >> col == maskFive
                 && ((maskSeven << col) & numbersForCountingBlocks[row + 2]) >> col == maskSeven)
                {
                    redBlocks++;
                    numbersForCountingBlocks[row] &= ~(maskSeven << col);
                    numbersForCountingBlocks[row + 1] &= ~(maskFive << col);
                    numbersForCountingBlocks[row + 2] &= ~(maskSeven << col);
                }
            }
        }
        //Counting Blue Blocks and clearing each block after it is counted
        for (int row = 0; row <= 16 - 3; row++)
        {
            for (int col = 5; col >= 0; col--)
            {
                if (((maskSeven << col) & numbersForCountingBlocks[row]) >> col == maskSeven
                 && ((maskFive << col) & numbersForCountingBlocks[row + 1]) >> col == maskFive
                 && ((maskSeven << col) & numbersForCountingBlocks[row + 2]) >> col == maskSeven)
                {
                    blueBlocks++;
                    numbersForCountingBlocks[row] &= ~(maskSeven << col);
                    numbersForCountingBlocks[row + 1] &= ~(maskFive << col);
                    numbersForCountingBlocks[row + 2] &= ~(maskSeven << col);
                }
            }
        }
       
        while (!disarmedBlue && !disarmedRed && !blueDetonated && !redDetonated && !capacitorHitted)
        {
            string command = Console.ReadLine();
            if (command == "hover")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                int bitPosition = 15 - col;

                if ((numbers[row] & 1 << bitPosition) >> bitPosition == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            if (command == "operate")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                int bitPosition = 15 - col;

                if ((numbers[row] & 1 << bitPosition) >> bitPosition == 1)
                {
                    capacitorHitted = true;                  
                }
                else
                {
                    if (row > 0 && row < 15 && bitPosition >= 8)
                    {
                        if ((numbers[row - 1] & maskSeven << bitPosition - 1) 
                          >> bitPosition - 1 == maskSeven
                          && (numbers[row] & maskFive << bitPosition - 1) 
                          >> bitPosition - 1 == maskFive
                          && (numbers[row + 1] & maskSeven << bitPosition - 1) 
                           >> bitPosition - 1 == maskSeven)
                        {
                            redBlocks--;
                            numbers[row - 1] &= ~(maskSeven << bitPosition - 1);
                            numbers[row] &= ~(maskFive << bitPosition - 1);
                            numbers[row + 1] &= ~(maskSeven << bitPosition - 1);
                        }
                    }

                    if (row > 0 && row < 15 && bitPosition <= 6)
                    {
                        if ((numbers[row - 1] & maskSeven << bitPosition - 1) 
                          >> bitPosition - 1 == maskSeven
                          && (numbers[row] & maskFive << bitPosition - 1) 
                           >> bitPosition - 1 == maskFive
                          && (numbers[row + 1] & maskSeven << bitPosition - 1) 
                           >> bitPosition - 1 == maskSeven)
                        {
                            blueBlocks--;
                            numbers[row - 1] &= ~(maskSeven << bitPosition - 1);
                            numbers[row] &= ~(maskFive << bitPosition - 1);
                            numbers[row + 1] &= ~(maskSeven << bitPosition - 1);
                        }
                    }
                }

            }
            if (command == "cut")
            {
                string color = Console.ReadLine();
                if (color == "blue" && blueBlocks == 0)
                {
                    disarmedBlue = true;                   
                }
                if (color == "blue" && blueBlocks > 0)
                {
                    blueDetonated = true;                   
                }

                if ((color == "red" || color == "left") && redBlocks == 0)
                {
                    disarmedRed = true;                    
                }
                if ((color == "red" || color == "left") && redBlocks > 0)
                {
                    redDetonated = true;                    
                }
            }
        }

        if (disarmedBlue)
        {
            Console.WriteLine(redBlocks);
            Console.WriteLine("disarmed");
        }
        if (disarmedRed)
        {
            Console.WriteLine(blueBlocks);
            Console.WriteLine("disarmed");
        }
        if (capacitorHitted)
        {
            Console.WriteLine("missed");
            Console.WriteLine(blueBlocks + redBlocks);
            Console.WriteLine("BOOM");
        }
        if (blueDetonated)
        {
            Console.WriteLine(blueBlocks);
            Console.WriteLine("BOOM");
        }
        if (redDetonated)
        {
            Console.WriteLine(redBlocks);
            Console.WriteLine("BOOM");
        }        
    }
}