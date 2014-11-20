using System;

class AngryBits
{
    static void Main()
    {
        ushort[] numbers = new ushort[8];
        string direction = String.Empty;
        string[] binary = new string[8];
        char[,] matrix = new char[8, 16];
        
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = ushort.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 8; i++)
        {
            binary[i] = Convert.ToString(numbers[i], 2).PadLeft(16, '0'); 
        }

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 16; col++)
            {
                matrix[row, col] = binary[row][col];
            }
        }

        bool allPigsKilled = true;

        int totalScore = CalculateScore(matrix, 0, 7, false, String.Empty, 0, 0, 0) 
                       + CalculateScore(matrix, 0, 6, false, String.Empty, 0, 0, 0)
                       + CalculateScore(matrix, 0, 5, false, String.Empty, 0, 0, 0)
                       + CalculateScore(matrix, 0, 4, false, String.Empty, 0, 0, 0)
                       + CalculateScore(matrix, 0, 3, false, String.Empty, 0, 0, 0)
                       + CalculateScore(matrix, 0, 2, false, String.Empty, 0, 0, 0)
                       + CalculateScore(matrix, 0, 1, false, String.Empty, 0, 0, 0)
                       + CalculateScore(matrix, 0, 0, false, String.Empty, 0, 0, 0);

        for (int row = 0; row < 8; row++)
        {
            for (int col = 8; col < 16; col++)
            {
                if (matrix[row, col] == '1')
                {
                    allPigsKilled = false;
                }
            }
        }

        if (allPigsKilled)
        {
            Console.WriteLine(totalScore + " Yes");
        }
        else
        {
            Console.WriteLine(totalScore + " No");
        }                           
    }

    private static int CalculateScore (char [,] matrix, int rowWithBird, int columnWithBird,
                                       bool haveBird, string direction, int trackLength, 
                                       int pigsKilled, int score)
    {
       
        for (int row = 0; row < 8; row++)
        {
            if (matrix[row, columnWithBird] == '1')
            {
                rowWithBird = row;
                haveBird = true;
            }
        }

        if (haveBird)
        {
            if (rowWithBird == 0)
            {
                direction = "down";
            }
            else
            {
                direction = "up";
            }
        }

        while (true)
        {
            if (direction == "down")
            {                
                matrix[rowWithBird, columnWithBird] = '0';
                
                if (rowWithBird + 1 <= 7 && columnWithBird + 1 <= 15)
                {
                    rowWithBird++;
                    columnWithBird++;
                    if (matrix[rowWithBird, columnWithBird] == '0')
                    {
                        trackLength++;
                    }
                    else if (matrix[rowWithBird, columnWithBird] == '1')
                    {
                        matrix[rowWithBird, columnWithBird] = '0';
                        pigsKilled++;
                        trackLength++;
                        pigsKilled += KillPigsAround(matrix, rowWithBird, columnWithBird);
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            else if (direction == "up")
            {
                matrix[rowWithBird, columnWithBird] = '0';

                if (rowWithBird - 1 >= 0 && columnWithBird + 1 <= 15)
                {
                    rowWithBird--;
                    columnWithBird++;
                    if (matrix[rowWithBird, columnWithBird] == '0')
                    {
                        trackLength++;
                    }
                    else if (matrix[rowWithBird, columnWithBird] == '1')
                    {
                        matrix[rowWithBird, columnWithBird] = '0';
                        trackLength++;
                        pigsKilled++;
                        pigsKilled += KillPigsAround(matrix, rowWithBird, columnWithBird);
                        break;
                    }
                }
                else
                {
                    direction = "down";
                }
            }
            else
            {
                break;
            }
        }
        score += pigsKilled * trackLength;
        return score;
    }
    private static int KillPigsAround(char[,] matrix, int rowWithBird, int columnWithBird)
    {
        int pigsKilledAround = 0;
        if (rowWithBird - 1 >= 0 && columnWithBird - 1 >= 8)
        {
            if (matrix[rowWithBird - 1, columnWithBird - 1] == '1')
            {
                matrix[rowWithBird - 1, columnWithBird - 1] = '0';
                pigsKilledAround++;
            }
        }
        if (rowWithBird - 1 >= 0)
        {
            if (matrix[rowWithBird - 1, columnWithBird] == '1')
            {
                matrix[rowWithBird - 1, columnWithBird] = '0';
                pigsKilledAround++;
            }
        }
        if (rowWithBird - 1 >= 0 && columnWithBird + 1 <= 15)
        {
            if (matrix[rowWithBird - 1, columnWithBird + 1] == '1')
            {
                matrix[rowWithBird - 1, columnWithBird + 1] = '0';
                pigsKilledAround++;
            }
        }
        if (columnWithBird - 1 >= 8)
        {
            if (matrix[rowWithBird, columnWithBird - 1] == '1')
            {
                matrix[rowWithBird, columnWithBird - 1] = '0';
                pigsKilledAround++;
            }
        }
        if (columnWithBird + 1 <= 15)
        {
            if (matrix[rowWithBird, columnWithBird + 1] == '1')
            {
                matrix[rowWithBird, columnWithBird + 1] = '0';
                pigsKilledAround++;
            }
        }
        if (rowWithBird + 1 <= 7 && columnWithBird - 1 >= 8)
        {
            if (matrix[rowWithBird + 1, columnWithBird - 1] == '1')
            {
                matrix[rowWithBird + 1, columnWithBird - 1] = '0';
                pigsKilledAround++;
            }
        }
        if (rowWithBird + 1 <= 7)
        {
            if (matrix[rowWithBird + 1, columnWithBird] == '1')
            {
                matrix[rowWithBird + 1, columnWithBird] = '0';
                pigsKilledAround++;
            }
        }
        if (rowWithBird + 1 <= 7 && columnWithBird + 1 <= 15)
        {
            if (matrix[rowWithBird + 1, columnWithBird + 1] == '1')
            {
                matrix[rowWithBird + 1, columnWithBird + 1] = '0';
                pigsKilledAround++;
            }
        }
        return pigsKilledAround;
    }
}