using System;

class Garden
{
    static void Main()
    {
        double tomatoSeeds = double.Parse(Console.ReadLine()) * 0.5;
        int tomatoArea = int.Parse(Console.ReadLine());
        double cucumberSeeds = double.Parse(Console.ReadLine()) * 0.4;
        int cucumberArea = int.Parse(Console.ReadLine());
        double potatoSeeds = double.Parse(Console.ReadLine()) * 0.25;
        int potatoArea = int.Parse(Console.ReadLine());
        double carrotSeeds = double.Parse(Console.ReadLine()) * 0.6;
        int carrotArea = int.Parse(Console.ReadLine());
        double cabbageSeeds = double.Parse(Console.ReadLine()) * 0.3;
        int cabbageArea = int.Parse(Console.ReadLine());
        double beansSeeds = int.Parse(Console.ReadLine()) * 0.4;
        int beansArea = 250 - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);

        double totalCost = tomatoSeeds + cucumberSeeds + potatoSeeds + carrotSeeds + cabbageSeeds + beansSeeds;
 
        if (beansArea > 0)
        {
            Console.WriteLine("Total costs: {0:f2} \nBeans area: {1}", totalCost, beansArea);
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("Total costs: {0:f2} \nNo area for beans", totalCost);
        }
        else
        {
            Console.WriteLine("Total costs: {0:f2} \nInsufficient area", totalCost);
        }
    }
}