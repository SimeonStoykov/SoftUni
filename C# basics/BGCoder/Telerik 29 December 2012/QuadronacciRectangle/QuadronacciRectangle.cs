using System;
using System.Collections.Generic;

class QuadronacciRectangle
{
    static void Main()
    {
        long firstNum = long.Parse(Console.ReadLine());
        long secondNum = long.Parse(Console.ReadLine());
        long thirdNum = long.Parse(Console.ReadLine());
        long fourthNum = long.Parse(Console.ReadLine());
        long nextNum = 0;

        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int colsCount = cols;

        List<long> numbers = new List<long>();
        numbers.Add(firstNum);
        numbers.Add(secondNum);
        numbers.Add(thirdNum);
        numbers.Add(fourthNum);

        for (int i = 0; i < rows*cols - 4; i++)
        {
            nextNum = firstNum + secondNum + thirdNum + fourthNum;
            firstNum = secondNum;
            secondNum = thirdNum;
            thirdNum = fourthNum;
            fourthNum = nextNum;
            numbers.Add(nextNum);
        }

        int col = 0;
        for (int row = 0; row < rows; row++)
        {
            for (; col < cols; col++)
            {
                Console.Write(numbers[col] + " ");
            }
            cols += colsCount;
            Console.WriteLine();
        }
    }
}