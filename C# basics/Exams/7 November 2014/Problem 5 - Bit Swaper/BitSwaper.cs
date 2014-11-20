using System;

class BitSwaper
{
    static void Main()
    {
        uint[] numbers = new uint[4];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }

        while (true)
        {
            string command1 = Console.ReadLine();

            if (command1 == "End")
            {
                break;
            }

            string command2 = Console.ReadLine();

            string[] commands1 = command1.Split();
            string[] commands2 = command2.Split();

            int firstNumberToSwap = int.Parse(commands1[0].ToString());
            int numberToChangeFirst = firstNumberToSwap;
            int firstPartOfBitsToSwap = int.Parse(commands1[1].ToString());
            int secondNumberToSwap = int.Parse(commands2[0].ToString());
            int numberToChangeSecond = secondNumberToSwap;
            int secondPartOfBitsToSwap = int.Parse(commands2[1].ToString());

            if (firstNumberToSwap != secondNumberToSwap)
            {
                uint firstToSwap = (numbers[firstNumberToSwap] & ((uint)15 << (firstPartOfBitsToSwap * 4))) 
                                >> (firstPartOfBitsToSwap * 4);
                uint secondToSwap = (numbers[secondNumberToSwap] & ((uint)15 << (secondPartOfBitsToSwap * 4))) 
                                 >> (secondPartOfBitsToSwap * 4);

                uint newFirstNumber = numbers[firstNumberToSwap] & ~((uint)15 << (firstPartOfBitsToSwap * 4));
                newFirstNumber = newFirstNumber | (secondToSwap << (firstPartOfBitsToSwap * 4));

                uint newSecondNumber = numbers[secondNumberToSwap] & ~((uint)15 << (secondPartOfBitsToSwap * 4));
                newSecondNumber = newSecondNumber | (firstToSwap << (secondPartOfBitsToSwap * 4));

                numbers[numberToChangeFirst] = newFirstNumber;
                numbers[numberToChangeSecond] = newSecondNumber;
            }
            else
            {
                uint firstToSwap = (numbers[firstNumberToSwap] & ((uint)15 << (firstPartOfBitsToSwap * 4))) 
                                >> (firstPartOfBitsToSwap * 4);
                uint secondToSwap = (numbers[secondNumberToSwap] & ((uint)15 << (secondPartOfBitsToSwap * 4))) 
                                 >> (secondPartOfBitsToSwap * 4);

                uint newFirstNumber = numbers[firstNumberToSwap] & ~((uint)15 << (firstPartOfBitsToSwap * 4));
                newFirstNumber = newFirstNumber & ~((uint)15 << (secondPartOfBitsToSwap * 4));

                newFirstNumber = newFirstNumber | (firstToSwap << (secondPartOfBitsToSwap * 4));
                newFirstNumber = newFirstNumber | (secondToSwap << (firstPartOfBitsToSwap * 4));
                numbers[numberToChangeFirst] = newFirstNumber;
            }
        }

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }        
    }
}