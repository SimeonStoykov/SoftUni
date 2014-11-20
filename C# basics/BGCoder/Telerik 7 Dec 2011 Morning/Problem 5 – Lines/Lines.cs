using System;

class Lines
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];

        for (int row = 0; row < 8; row++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                int currentBit = (number & (1 << col)) >> col;
                matrix[row, col] = currentBit;
            }
        }

        int longestLine = 0;
        int longestLineCount = 0;

        for (int row = 0; row < 8; row++)
        {
            int currentLine = 0;
            for (int col = 0; col < 8; col++)
            {
                while (col < 8 && matrix[row, col] == 1)
                {
                    currentLine++;
                    col++;
                }

                if (currentLine > longestLine)
                {
                    longestLine = currentLine;
                    longestLineCount = 1;
                }
                else if (currentLine == longestLine)
                {
                    longestLineCount++;
                }

                currentLine = 0;
            }
        }

        for (int col = 0; col < 8; col++)
        {
            int currentLine = 0;
            for (int row = 0; row < 8; row++)
            {
                while (row < 8 && matrix[row, col] == 1)
                {
                    currentLine++;
                    row++;
                }

                if (currentLine > longestLine)
                {
                    longestLine = currentLine;
                    longestLineCount = 1;
                }
                else if (currentLine == longestLine)
                {
                    longestLineCount++;
                }

                currentLine = 0;
            }
        }

        if (longestLine == 1)
        {
            longestLineCount /= 2;
        }
        Console.WriteLine(longestLine);
        Console.WriteLine(longestLineCount);
    }
}