using System;

class UKFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int left = 0;
        int right = n - 1;
        int middle = n / 2;

        for (int row = 0; row < middle; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == left)
                {
                    Console.Write("\\");
                }
                else if (col == right)
                {
                    Console.Write("/");
                }
                else if (col == middle)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(".");
                }
            }
            left++;
            right--;
            Console.WriteLine();
        }

        Console.WriteLine("{0}*{0}", new String ('-', n/2));

        left = n / 2 - 1;
        right = (n / 2) + 1;

        for (int row = 0; row < middle; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == left)
                {
                    Console.Write("/");
                }
                else if (col == right)
                {
                    Console.Write("\\");
                }
                else if (col == middle)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(".");
                }
            }
            left--;
            right++;
            Console.WriteLine();
        }
    }
}