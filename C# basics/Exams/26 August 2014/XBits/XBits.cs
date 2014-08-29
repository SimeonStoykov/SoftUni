using System;

class XBits
{
    static void Main()
    {
        int[] numbers = new int[8];
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        string[] numbersStr = new string[8];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbersStr[i] = Convert.ToString(numbers[i], 2).PadLeft(32, '0');
        }

        for (int i = 0; i <= 5; i++)
        {
            for (int s = 0; s <= 29; s++)
            {
                if (numbersStr[i].Substring(s, 3) == "101" && numbersStr[i + 1].Substring(s, 3) == "010" 
                 && numbersStr[i + 2].Substring(s, 3) == "101")
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);      
    }
}