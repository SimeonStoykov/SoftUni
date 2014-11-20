using System;

class FallDown
{
    static void Main()
    {
        int[] numbers = new int[8];
        string[] numbersStr = new string[8];      
        char[,] matrix = new char[8, 8];
        int colZero = 0;
        int colOne = 0;
        int colTwo = 0;
        int colThree = 0;
        int colFour = 0;
        int colFive = 0;
        int colSix = 0;
        int colSeven = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                matrix[row, col] = '0';
            }
        }

        for (int i = 0; i < numbersStr.Length; i++)
        {
            numbersStr[i] = Convert.ToString(numbers[i], 2).PadLeft(8, '0');
        }

        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (numbersStr[row][col] == '1')
                {
                    switch (col)
                    {
                        case 0: colZero++; break;
                        case 1: colOne++;  break;
                        case 2: colTwo++; break;
                        case 3: colThree++; break;
                        case 4: colFour++;  break;
                        case 5: colFive++; break;
                        case 6: colSix++; break;
                        case 7: colSeven++; break;
                    }
                }
            }           
        }

        int currentRow = 0;

        for (int col = 0; col < 8; col++)
        {          
            switch (col)
            {
                case 0: currentRow = 8 - colZero; break;
                case 1: currentRow = 8 - colOne; break;
                case 2: currentRow = 8 - colTwo; break;
                case 3: currentRow = 8 - colThree; break;
                case 4: currentRow = 8 - colFour; break;
                case 5: currentRow = 8 - colFive; break;
                case 6: currentRow = 8 - colSix; break;
                case 7: currentRow = 8 - colSeven; break;
            }

            for (int i = currentRow; i <= 7; i++)
            {
                matrix[i, col] = '1';
            }            
        }

        string[] newNumbersBinary = new string[8];

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                newNumbersBinary[row] += matrix[row, col];
            }
        }

        int[] newNumbers = new int[8];

        for (int i = 0; i < newNumbers.Length; i++)
        {
            newNumbers[i] = Convert.ToInt32(newNumbersBinary[i], 2);
        }

        foreach (var item in newNumbers)
        {
            Console.WriteLine(item);
        }
    }
}