using System;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        string allNumbers = String.Empty;
        int dancingBits = 0;

        for (int i = 0; i < N; i++)
        {
            int number = int.Parse(Console.ReadLine());
            allNumbers += Convert.ToString(number, 2);
        }

        int currentCounter = 1;

        for (int i = 0; i < allNumbers.Length; i+= currentCounter)
        {
            currentCounter = 1;
            int indexCounter = i;

            while (true)
            {
                if (indexCounter < allNumbers.Length - 1)
                {
                    char currentChar = allNumbers[indexCounter];
                    char nextChar = allNumbers[indexCounter + 1];

                    if (currentChar == nextChar)
                    {
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }
                    indexCounter++;
                }
                else
                {
                    break;
                }
            }

            if (currentCounter == k)
            {
                dancingBits++;
            }
        }

        Console.WriteLine(dancingBits);
    }
}