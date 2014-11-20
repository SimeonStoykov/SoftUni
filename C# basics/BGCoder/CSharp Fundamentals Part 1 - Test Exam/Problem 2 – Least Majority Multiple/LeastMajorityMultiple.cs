using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int [] numbers = new int[5];
        int counter = 0;
        int leastMajorityMultipleCounter = 0;
        int leastMajorityMultiple = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        while (true)
        {
            counter++;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter % numbers[i] == 0)
                {
                    leastMajorityMultipleCounter++;
                }
            }
            if (leastMajorityMultipleCounter >= 3)
            {
                leastMajorityMultiple = counter;
                break;
            }
            leastMajorityMultipleCounter = 0;
        }

        Console.WriteLine(leastMajorityMultiple);
    }
}