using System;

class ChessQueens
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int counter = 0;

        for (char row = 'a'; row < 'a'+ N; row++)
        {
            for (int col = 1; col <= N; col++)
            {
                if (row - D - 1 >= 'a' && col - D - 1 >= 1)
                {
                    Console.WriteLine((char)row + "" + col + " - " + (char)(row - D - 1) + "" + (col - D - 1));
                    counter++;
                }
                if (row - D - 1 >= 'a' )
                {
                    Console.WriteLine((char)row + "" + col + " - " + (char)(row - D - 1) + "" + col);
                    counter++;
                }
                if (row - D - 1 >= 'a' && col + D + 1 <= N)
                {
                    Console.WriteLine((char)row + "" + col + " - " + (char)(row - D - 1) + "" + (col + D + 1));
                    counter++;
                }
                if (col - D - 1 >= 1)
                {
                    Console.WriteLine((char)row + "" + col + " - " + (char)row + "" + (col - D - 1));
                    counter++;
                }
                if (col + D + 1 <= N)
                {
                    Console.WriteLine((char)row + "" + col + " - " + (char)row + "" + (col + D + 1));
                    counter++;
                }
                if (row + D + 1 < 'a' + N && col - D - 1 >=1)
                {
                    Console.WriteLine((char)row + "" + col + " - " + (char)(row + D + 1) + "" + (col - D - 1));
                    counter++;
                }
                if (row + D + 1 < 'a' + N)
                {
                    Console.WriteLine((char)row + "" + col + " - " + (char)(row + D + 1) + "" + col);
                    counter++;
                }
                if (row + D + 1 < 'a' + N && col + D + 1 <=N )
                {
                    Console.WriteLine((char)row + "" + col + " - " + (char)(row + D + 1) + "" + (col + D + 1));
                    counter++;
                }
            } 
        }

        if (counter==0)
        {
            Console.WriteLine("No valid positions");
        }
    }
}                    