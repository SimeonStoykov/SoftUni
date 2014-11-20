using System;

class WeirdCombinations
{
    static void Main()
    {
        string inputToTake = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        int counter = -1;
        string neededString = String.Empty;

        char[] input = inputToTake.ToCharArray();

        for (int d1 = 0; d1 < input.Length; d1++)
        {
            for (int d2 = 0; d2 < input.Length; d2++)
            {
                for (int d3 = 0; d3 < input.Length; d3++)
                {
                    for (int d4 = 0; d4 < input.Length; d4++)
                    {
                        for (int d5 = 0; d5 < input.Length; d5++)
                        {
                            string combination = input[d1].ToString() + input[d2] + input[d3]
                                               + input[d4] + input[d5];
                            counter++;
                            if (counter == n)
                            {
                                neededString = combination;
                            }
                        }
                    }
                }
            }
        }

        if (neededString == String.Empty)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(neededString);
        }    
    }
}