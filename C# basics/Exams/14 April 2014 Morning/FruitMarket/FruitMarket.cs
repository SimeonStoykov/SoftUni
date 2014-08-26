using System;
using System.Globalization;
using System.Threading;

class FruitMarket
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        string day = Console.ReadLine();
        double quantity1 = double.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        double quantity2 = double.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        double quantity3 = double.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();
        double result1=0;
        double result2=0;
        double result3=0;
        double bananaPrice = 1.80;
        double cucumberPrice = 2.75;
        double tomatoPrice = 3.20;
        double orangePrice = 1.60;
        double applePrice = 0.86;

        switch (day)
        {
            case "Friday": bananaPrice=0.9*bananaPrice ;
                           cucumberPrice = 0.9 * cucumberPrice;
                           tomatoPrice = 0.9 * tomatoPrice;
                           orangePrice = 0.9 * orangePrice;
                           applePrice = 0.9 * applePrice; break;
            case "Sunday": bananaPrice = 0.95 * bananaPrice;
                           cucumberPrice = 0.95 * cucumberPrice;
                           tomatoPrice = 0.95 * tomatoPrice;
                           orangePrice = 0.95 * orangePrice;
                           applePrice = 0.95 * applePrice; break;
            case "Tuesday": bananaPrice = 0.8 * bananaPrice;
                            orangePrice = 0.8 * orangePrice;
                            applePrice = 0.8 * applePrice; break;
            case "Wednesday": cucumberPrice = 0.90 * cucumberPrice;
                              tomatoPrice = 0.90 * tomatoPrice; break;
            case "Thursday": bananaPrice = 0.7 * bananaPrice; break;               
        }

        if (product1=="banana")
        {
            result1 = bananaPrice * quantity1; 
        }
        if (product1 == "cucumber")
        {
                result1 = cucumberPrice * quantity1;
        }
        if (product1 == "tomato")
        {
                result1 = tomatoPrice * quantity1;
        }
        if (product1 == "orange")
        {
                result1 = orangePrice * quantity1;
        }
        if (product1 == "apple")
        {
                result1 = applePrice * quantity1;
        }

        if (product2 == "banana")
        {
                result2 = bananaPrice * quantity2;
        }
        if (product2 == "cucumber")
        {
                result2 = cucumberPrice * quantity2;
        }
        if (product2 == "tomato")
        {
                result2 = tomatoPrice * quantity2;
        }
        if (product2 == "orange")
        {
                result2 = orangePrice * quantity2;
        }
        if (product2 == "apple")
        {
                result2 = applePrice * quantity2;
        }

        if (product3 == "banana")
        {
                result3 = bananaPrice * quantity3;
        }
        if (product3 == "cucumber")
        {
                result3 = cucumberPrice * quantity3;
        }
        if (product3 == "tomato")
        {
                result3 = tomatoPrice * quantity3;
        }
        if (product3 == "orange")
        {
                result3 = orangePrice * quantity3;
        }
        if (product3 == "apple")
        {
                result3 = applePrice * quantity3;
        }
            
        double totalPrice = result1+result2+result3;
        Console.WriteLine("{0:f2}", totalPrice);
    }
}

