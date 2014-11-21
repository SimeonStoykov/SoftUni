using System;

class Gambling
{
    static void Main()
    {
        double cash = double.Parse(Console.ReadLine());
        string[] houseHand = Console.ReadLine().Split();
        int houseHandStregth = 0;
        double totalHands = 0;
        double strongerHands = 0;

        for (int i = 0; i < houseHand.Length; i++)
        {
            switch (houseHand[i])
            {
                case "J": houseHandStregth += 11; break;
                case "Q": houseHandStregth += 12; break;
                case "K": houseHandStregth += 13; break;
                case "A": houseHandStregth += 14; break;
                default: houseHandStregth += int.Parse(houseHand[i]); break;
            }
        }

        for (int card1 = 2; card1 <= 14; card1++)
        {
            for (int card2 = 2; card2 <= 14; card2++)
            {
                for (int card3 = 2; card3 <= 14; card3++)
                {
                    for (int card4 = 2; card4 <= 14; card4++)
                    {
                        totalHands++;
                        int currentHandStrength = card1 + card2 + card3 + card4;
                        if (currentHandStrength > houseHandStregth)
                        {
                            strongerHands++;
                        }
                    }
                }
            }
        }

        double chanceToWin = strongerHands / totalHands;
        double expectedWinnigs = cash * 2 * chanceToWin;
        if (chanceToWin < 0.5)
        {
            Console.WriteLine("FOLD");
            Console.WriteLine("{0:f2}", expectedWinnigs);
        }
        else
        {
            Console.WriteLine("DRAW");
            Console.WriteLine("{0:f2}", expectedWinnigs);
        }
    }
}