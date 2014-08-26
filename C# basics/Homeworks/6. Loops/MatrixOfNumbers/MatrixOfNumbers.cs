using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
            int cols = i + 1;

            for (int j = 2; j <= n; j++)
            {
                Console.Write(cols);
                cols++;                                       
            }

            Console.WriteLine();                
        }
    }
}

