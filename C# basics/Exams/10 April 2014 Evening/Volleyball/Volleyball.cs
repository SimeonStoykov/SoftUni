using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double game = (2 * p)/3 + (48 - h) * 3 / 4 + h;
        double leapGame = game * 1.15;

        if (year=="normal")
        {
            Console.WriteLine((int)game);
        }
        else if (year=="leap")
        {
            Console.WriteLine((int)leapGame);
        }
    }
}

