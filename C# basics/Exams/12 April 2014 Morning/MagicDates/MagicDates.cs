using System;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);

        bool isOk = false;

        for (DateTime i = startDate; i <= endDate; i=i.AddDays(1))
        {
            int d1 = i.Day / 10;
            int d2 = i.Day % 10;
            int d3 = i.Month / 10;
            int d4 = i.Month % 10;
            int d5 = (i.Year / 1000)%10;
            int d6 = (i.Year / 100)%10;
            int d7 = (i.Year / 10)%10;
            int d8 = (i.Year/1)%10;

            int[] digits = { d1, d2, d3, d4, d5, d6, d7, d8 };

            if (d1 * d2 + d1 * d3 + d1 * d4 + d1 * d5 + d1 * d6 + d1 * d7 + d1 * d8 + d2 * d3 + d2 * d4 + d2 * d5
              + d2 * d6 + d2 * d7 + d2 * d8 + d3 * d4 + d3 * d5 + d3 * d6 + d3 * d7 + d3 * d8 + d4 * d5 + d4 * d6 
              + d4 * d7 + d4 * d8 + d5 * d6 + d5 * d7 + d5 * d8 + d6 * d7 + d6 * d8 + d7 * d8 == magicWeight)
            {
                isOk = true;
                Console.WriteLine("" + d1 + d2 + "-" + d3 + d4 + "-" + d5 + d6 + d7 + d8);
            }              
        }

        if (isOk==false)
        {
            Console.WriteLine("No");
        }            
    }
}