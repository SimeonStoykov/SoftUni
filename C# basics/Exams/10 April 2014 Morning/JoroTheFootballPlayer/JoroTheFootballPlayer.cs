using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        if (year=="t")
        {
            int games = p / 2 + (52 - h) * 2 / 3 + h + 3;
            Console.WriteLine(games);
        }
        else if (year=="f")
        {
            int games = p / 2 + (52 - h) * 2 / 3 + h;
            Console.WriteLine(games);
        }
        else
        {
            Console.WriteLine("Invalid year");
        }
    }
}

