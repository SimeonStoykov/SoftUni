using System;

class OddOrEvenCounter
{
    static void Main()
    {
        int countOfSets = int.Parse(Console.ReadLine());
        int countOfNumbersInEachSet = int.Parse(Console.ReadLine());
        int[] numbersInEachSet = new int[countOfNumbersInEachSet];
        string oddOreven = Console.ReadLine();
        int maxOdd = 0;
        int maxEven = 0;
        string hasMostNumbers = String.Empty;
        int counter = 0;

        for (int i = 0; i < countOfSets; i++)
        {
            for (int j = 0; j < numbersInEachSet.Length; j++)
            {
                numbersInEachSet[j] = int.Parse(Console.ReadLine());
            }

            int countOdd = 0;
            int countEven = 0;

            for (int j = 0; j < numbersInEachSet.Length; j++)
            {
                if (numbersInEachSet[j] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            if (oddOreven == "odd")
            {
                if (countOdd > maxOdd)
                {
                    counter++;
                    maxOdd = countOdd;
                    switch (i)
                    {
                        case 0: hasMostNumbers = "First"; break;
                        case 1: hasMostNumbers = "Second"; break;
                        case 2: hasMostNumbers = "Third"; break;
                        case 3: hasMostNumbers = "Fourth"; break;
                        case 4: hasMostNumbers = "Fifth"; break;
                        case 5: hasMostNumbers = "Sixth"; break;
                        case 6: hasMostNumbers = "Seventh"; break;
                        case 7: hasMostNumbers = "Eighth"; break;
                        case 8: hasMostNumbers = "Ninth"; break;
                        case 9: hasMostNumbers = "Tenth"; break;
                    }
                }
            }
            else
            {
                if (countEven > maxEven)
                {
                    counter++;
                    maxEven = countEven;
                    switch (i)
                    {
                        case 0: hasMostNumbers = "First"; break;
                        case 1: hasMostNumbers = "Second"; break;
                        case 2: hasMostNumbers = "Third"; break;
                        case 3: hasMostNumbers = "Fourth"; break;
                        case 4: hasMostNumbers = "Fifth"; break;
                        case 5: hasMostNumbers = "Sixth"; break;
                        case 6: hasMostNumbers = "Seventh"; break;
                        case 7: hasMostNumbers = "Eighth"; break;
                        case 8: hasMostNumbers = "Ninth"; break;
                        case 9: hasMostNumbers = "Tenth"; break;
                    }
                }
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("No");
        }

        else if (oddOreven == "odd")
        {
           Console.WriteLine("{0} set has the most odd numbers: {1}", hasMostNumbers, maxOdd);
        }
        else
        {
           Console.WriteLine("{0} set has the most even numbers: {1}", hasMostNumbers, maxEven);
        }      
    }
}