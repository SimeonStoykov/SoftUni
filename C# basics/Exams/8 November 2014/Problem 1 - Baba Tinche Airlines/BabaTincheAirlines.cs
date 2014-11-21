using System;

class BabaTincheAirlines
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        string[] secondLine = Console.ReadLine().Split();
        string[] thirdLine = Console.ReadLine().Split();

        int firstClassPassengers = int.Parse(firstLine[0]);
        int businessClassPassengers = int.Parse(secondLine[0]);
        int economyClassPassengers = int.Parse(thirdLine[0]);

        int firstClassFrequentFlyers = int.Parse(firstLine[1]);
        int businessClassFrequentFlyers = int.Parse(secondLine[1]);
        int economyClassFrequentFlyers = int.Parse(thirdLine[1]);

        int firstClassMeals = int.Parse(firstLine[2]);
        int businessClassMeals = int.Parse(secondLine[2]);
        int economyClassMeals = int.Parse(thirdLine[2]);

        double maximumPossibleProfit = 12 * 7000 + 28 * 3500 + 50 * 1000
                                     + 12 * 7000 * 0.005 + 28 * 3500 * 0.005 + 50 * 1000 * 0.005;
        double currentProfit = (firstClassPassengers - firstClassFrequentFlyers) * 7000
                             + (businessClassPassengers - businessClassFrequentFlyers) * 3500
                             + (economyClassPassengers - economyClassFrequentFlyers) * 1000
                             + firstClassFrequentFlyers * 2100 + businessClassFrequentFlyers * 1050
                             + economyClassFrequentFlyers * 300 + firstClassMeals * 7000 * 0.005
                             + businessClassMeals * 3500 * 0.005 + economyClassMeals * 1000 * 0.005;

        Console.WriteLine((int)currentProfit);
        Console.WriteLine((int)(maximumPossibleProfit) - (int)(currentProfit));                                  
    }
}