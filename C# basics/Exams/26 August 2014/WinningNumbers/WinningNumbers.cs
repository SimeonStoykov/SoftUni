using System;

class WinningNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.ToUpper();
        int letSum = 0;
        int firstProduct = 1;
        int secondProduct = 1;
        int counter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            letSum += input[i] - '@';
        }

        for (int d1 = 0; d1 <= 9; d1++)
        {
            for (int d2 = 0; d2 <= 9; d2++)
            {
                for (int d3 = 0; d3 <= 9; d3++)
                {
                    for (int d4 = 0; d4 <= 9; d4++)
                    {
                        for (int d5 = 0; d5 <= 9; d5++)
                        {
                            for (int d6 = 0; d6 <= 9; d6++)
                            {
                                firstProduct = d1 * d2 * d3;
                                secondProduct = d4 * d5 * d6;
                                if (firstProduct==secondProduct && secondProduct==letSum)
                                {
                                    Console.WriteLine("{0}{1}{2}-{3}{4}{5}", d1, d2, d3, d4, d5, d6);
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}