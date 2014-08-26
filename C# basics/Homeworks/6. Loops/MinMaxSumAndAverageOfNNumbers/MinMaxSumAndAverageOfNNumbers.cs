using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        double maxValue = double.MinValue;
        double minValue = double.MaxValue;
        double average = 0;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
            if (number>maxValue)
            {
                maxValue = number;
            }
            if (number<minValue)
            {
                minValue = number;
            }
            average = sum / n;
        }

        Console.WriteLine("min={0} \nmax={1} \nsum={2} \navg={3:f2}", minValue, maxValue, sum, average);
    }
}

