using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());           
        int row = 0;
        int col = 0;
        int[,] matrix = new int[n, n];
        int maxRotations = n * n;
        string direction = "right";

        for (int i = 1; i <= maxRotations; i++)
        {               
            if (direction=="right" && ((col>n-1) || matrix[row,col]!=0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "left" && ((col < 0) || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && ((row < 0) || matrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }
            if (direction == "down" && ((row > n - 1) || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }

            matrix[row, col] = i;

            if (direction=="right")
            {
                col++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
            if (direction == "down")
            {
                row++;
            }              
        }

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                Console.Write("{0, 4}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }            
    }
}

