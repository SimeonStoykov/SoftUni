using System;

class NaBabamiSmetalnika
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());

        uint[] lines = new uint[8];
        for (int i = 0; i < 8; i++)
        {
            lines[i] = uint.Parse(Console.ReadLine());
        }

        while (true)
        {
            string str = Console.ReadLine();

            if (str == "stop") { break; }
            else if (str == "reset")
            {
                for (int i = 0; i < 8; i++)
                {
                    lines[i] = Move("left", width, width, lines[i]);
                }
            }
            else if (str == "left" || str == "right")
            {
                int y = int.Parse(Console.ReadLine());
                int pos = int.Parse(Console.ReadLine());
                lines[y] = Move(str, pos, width, lines[y]);
            }
        }

        long sum = (long)lines[0] + (long)lines[1] + (long)lines[2] + (long)lines[3] + (long)lines[4] 
                + (long)lines[5] + (long)lines[6] + (long)lines[7];
        uint sumBit = lines[0] | lines[1] | lines[2] | lines[3] | lines[4] | lines[5] | lines[6] | lines[7];

        int colsSumZero = width;
        for (int i = 0; i < width; i++)
        {
            colsSumZero -= (int)((sumBit & ((uint)1 << i)) >> i);
        }

        Console.WriteLine(sum * colsSumZero);
    }

    private static uint Move(string str, int pos, int width, uint line)
    {
        uint newBitMask = 0;

        if (pos < 0) { pos = 0; }
        if (pos > width) { pos = width - 1; }

        pos = width - pos - 1;

        if (str == "left")
        {
            int count = width - 1;
            for (int x = pos; x < width; x++)
            {
                uint mask = (uint)1 << x;
                if ((mask & line) == mask)
                {
                    newBitMask |= ((uint)1 << count);
                    count--;
                }
                line &= ~mask;
            }
        }
        else
        {
            int count = 0;
            for (int x = pos; x >= 0; x--)
            {
                uint mask = (uint)1 << x;
                if ((mask & line) == mask)
                {
                    newBitMask |= ((uint)1 << count);
                    count++;
                }
                line &= ~mask;
            }
        }
        return newBitMask | line;
    }
}

//ALTERNATIVE SOLUTION

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
 
//namespace Neurons
//{
//        class Program
//        {
//                static void Main(string[] args)
//                {
//                        const string LEFT_CMD = "left";
//                        const string RIGHT_CMD = "right";
//                        const string RESET_CMD = "reset";
//                        const string STOP_CMD = "stop";
 
//                        int width = int.Parse(Console.ReadLine());
//                        int[,] matrix = new int[8, width];
 
//                        for (int i = 0; i < 8; i++)
//                        {
//                                long number = long.Parse(Console.ReadLine());
//                                for (int j = 0, k = width-1; j < width; j++, k--)
//                                {
//                                        matrix[i, k] = (int)((number >> j) & 1);
//                                }
//                        }
//                        string command = Console.ReadLine();
//                        while (command != STOP_CMD)
//                        {
//                                if (command == LEFT_CMD)
//                                {
//                                        int currentY = int.Parse(Console.ReadLine());
//                                        int currentX = int.Parse(Console.ReadLine());
 
//                                        if (currentX > width - 1) currentX = width - 1;
 
//                                        int count = 0;
 
//                                        for (int i = currentX; i >= 0; i--)
//                                        {
//                                                if (matrix[currentY, i] == 1) ++count;
//                                                matrix[currentY, i] = 0;
//                                        }
 
//                                        for (int i = count-1; i>=0 ; i--)
//                                        {
//                                                matrix[currentY, i] = 1;
//                                        }
//                                }
//                                else if (command == RIGHT_CMD)
//                                {
//                                        int currentY = int.Parse(Console.ReadLine());
//                                        int currentX = int.Parse(Console.ReadLine());
 
//                                        if (currentX < 0) currentX = 0;
 
//                                        int count = 0;
 
//                                        for (int i = currentX; i < width; i++)
//                                        {
//                                                if (matrix[currentY, i] == 1) ++count;
//                                                matrix[currentY, i] = 0;
//                                        }
 
//                                        for (int i = width-count; i < width; i++)
//                                        {
//                                                matrix[currentY, i] = 1;
//                                        }
//                                }
//                                else if (command == RESET_CMD)
//                                {
//                                        for (int row = 0; row < 8; row++)
//                                        {
//                                                int count = 0;
//                                                for (int col = 0; col < width; col++)
//                                                {
//                                                        if (matrix[row, col] == 1) ++count;
//                                                        matrix[row, col] = 0;
//                                                }
 
//                                                for (int j = 0; j < count; j++)
//                                                {
//                                                        matrix[row, j] = 1;
//                                                }
//                                        }
//                                }
 
//                                command = Console.ReadLine();
//                        }
 
//                        int countFreeCells = 0;
//                        for (int col = 0; col < width; col++)
//                        {
//                                bool freeCell = true;
//                                for (int row = 0; row < 8; row++)
//                                {
//                                        if (matrix[row, col] == 1) freeCell = false;
//                                }
//                                if (freeCell) ++countFreeCells;
//                        }
//                        long sum = 0;
 
//                        for (int i = 0; i < 8; i++)
//                        {
//                                string str = "";
//                                for (int j = 0; j < width; j++)
//                                {
//                                        str += matrix[i, j];
//                                }
//                                long number = Convert.ToInt64(str, 2);
//                                sum += number;
//                        }
 
//                        sum *= countFreeCells;
 
//                        Console.WriteLine(sum);
//                }
//        }
//}