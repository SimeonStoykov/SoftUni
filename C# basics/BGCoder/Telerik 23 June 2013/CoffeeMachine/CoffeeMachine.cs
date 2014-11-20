using System;

class CoffeeMachine
{
    static void Main()
    {
        double N1 = double.Parse(Console.ReadLine()) * 0.05;
        double N2 = double.Parse(Console.ReadLine()) * 0.10;
        double N3 = double.Parse(Console.ReadLine()) * 0.20;
        double N4 = double.Parse(Console.ReadLine()) * 0.50;
        double N5 = double.Parse(Console.ReadLine()) * 1.00;
        double A = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        double totalMoney = N1 + N2 + N3 + N4 + N5;
        double change = A - price;
        double moneyLeft = totalMoney - change;

        if (A >= price && change <= totalMoney)
        {
            Console.WriteLine("Yes {0:f2}", moneyLeft);
        }

        if (price > A)
        {
            Console.WriteLine("More {0:f2}", price - A);
        }

        if (A >= price && totalMoney < change)
        {
            Console.WriteLine("No {0:f2}", change - totalMoney);
        }
    }
}