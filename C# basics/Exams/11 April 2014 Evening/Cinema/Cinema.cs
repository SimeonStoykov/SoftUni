using System;

class Cinema
{
    static void Main()
    {
        string projection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        double premierePrice = 12.00;
        double normalPrice = 7.50;
        double discountPrice = 5.00;
        string leva = "leva";

        if (projection=="Premiere")
        {
            double income = rows * columns * premierePrice;
            Console.WriteLine("{0:0.00} {1}", income, leva);
        }
        if (projection == "Normal")
        {
            double income = rows * columns * normalPrice;
            Console.WriteLine("{0:0.00} {1}", income, leva);
        }
        if (projection == "Discount")
        {
            double income = rows * columns * discountPrice;
            Console.WriteLine("{0:0.00} {1}", income, leva);
        }
    }
}

