using System;

class TribonacciTriangle
{
    static void Main()
    {
        long firstNum = long.Parse(Console.ReadLine());
        long secondNum = long.Parse(Console.ReadLine());
        long thirdNum = long.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        long nextNum = 0;
        int numberOfMembers = 0;
        int counter = 3;
        int rowCounter = counter + 1;

        for (int i = 1; i <= rows; i++)
        {
            numberOfMembers += i;
        }

        Console.WriteLine(firstNum);
        Console.Write(secondNum + " " + thirdNum);
        Console.WriteLine();

        for (int i = 1; i <= numberOfMembers - 3; i++)
        {
            nextNum = firstNum + secondNum + thirdNum;
            firstNum = secondNum;
            secondNum = thirdNum;
            thirdNum = nextNum;
            Console.Write(nextNum + " ");
            if (i == counter)
            {
                Console.WriteLine();
                counter = counter + rowCounter;
                rowCounter++;
            }          
        }
    }
}