using System;
using System.Collections.Generic;
using System.Numerics;

class CardWars
{
    static void Main()
    {
        int fpHandStrength = 0;
        int spHandStrength = 0;
        int fpGamesWon = 0;
        int spGamesWon = 0;
        BigInteger fpTotalScore = 0;
        BigInteger spTotalScore = 0;
        bool matchWon = false;
        int games = int.Parse(Console.ReadLine());
              
        for (int i = 1; i <= games; i++)
        {
            string fpFirstCard = Console.ReadLine();
            string fpSecondCard = Console.ReadLine();
            string fpThirdCard = Console.ReadLine();
            string spFirstCard = Console.ReadLine();
            string spSecondCard = Console.ReadLine();
            string spThirdCard = Console.ReadLine();
                        
            switch (fpFirstCard)
            {
                case "2": fpHandStrength += 10; break;
                case "3": fpHandStrength += 9; break;
                case "4": fpHandStrength += 8; break;
                case "5": fpHandStrength += 7; break;
                case "6": fpHandStrength += 6; break;
                case "7": fpHandStrength += 5; break;
                case "8": fpHandStrength += 4; break;
                case "9": fpHandStrength += 3; break;
                case "10":fpHandStrength += 2; break;
                case "A": fpHandStrength += 1; break;
                case "J": fpHandStrength += 11; break;
                case "Q": fpHandStrength += 12; break;
                case "K": fpHandStrength += 13; break;               
                case "Z": fpTotalScore *= 2; break;
                case "Y": fpTotalScore -= 200; break;
            }
            switch (fpSecondCard)
            {
                case "2": fpHandStrength += 10; break;
                case "3": fpHandStrength += 9; break;
                case "4": fpHandStrength += 8; break;
                case "5": fpHandStrength += 7; break;
                case "6": fpHandStrength += 6; break;
                case "7": fpHandStrength += 5; break;
                case "8": fpHandStrength += 4; break;
                case "9": fpHandStrength += 3; break;
                case "10": fpHandStrength += 2; break;
                case "A": fpHandStrength += 1; break;
                case "J": fpHandStrength += 11; break;
                case "Q": fpHandStrength += 12; break;
                case "K": fpHandStrength += 13; break;              
                case "Z": fpTotalScore *= 2; break;
                case "Y": fpTotalScore -= 200; break;
                
            }
            switch (fpThirdCard)
            {
                case "2": fpHandStrength += 10; break;
                case "3": fpHandStrength += 9; break;
                case "4": fpHandStrength += 8; break;
                case "5": fpHandStrength += 7; break;
                case "6": fpHandStrength += 6; break;
                case "7": fpHandStrength += 5; break;
                case "8": fpHandStrength += 4; break;
                case "9": fpHandStrength += 3; break;
                case "10": fpHandStrength += 2; break;
                case "A": fpHandStrength += 1; break;
                case "J": fpHandStrength += 11; break;
                case "Q": fpHandStrength += 12; break;
                case "K": fpHandStrength += 13; break;              
                case "Z": fpTotalScore *= 2; break;
                case "Y": fpTotalScore -= 200; break;
            }

            switch (spFirstCard)
            {
                case "2": spHandStrength += 10; break;
                case "3": spHandStrength += 9; break;
                case "4": spHandStrength += 8; break;
                case "5": spHandStrength += 7; break;
                case "6": spHandStrength += 6; break;
                case "7": spHandStrength += 5; break;
                case "8": spHandStrength += 4; break;
                case "9": spHandStrength += 3; break;
                case "10": spHandStrength += 2; break;
                case "A": spHandStrength += 1; break;
                case "J": spHandStrength += 11; break;
                case "Q": spHandStrength += 12; break;
                case "K": spHandStrength += 13; break;                
                case "Z": spTotalScore *= 2; break;
                case "Y": spTotalScore -= 200; break;
            }
            switch (spSecondCard)
            {
                case "2": spHandStrength += 10; break;
                case "3": spHandStrength += 9; break;
                case "4": spHandStrength += 8; break;
                case "5": spHandStrength += 7; break;
                case "6": spHandStrength += 6; break;
                case "7": spHandStrength += 5; break;
                case "8": spHandStrength += 4; break;
                case "9": spHandStrength += 3; break;
                case "10": spHandStrength += 2; break;
                case "A": spHandStrength += 1; break;
                case "J": spHandStrength += 11; break;
                case "Q": spHandStrength += 12; break;
                case "K": spHandStrength += 13; break;               
                case "Z": spTotalScore *= 2; break;
                case "Y": spTotalScore -= 200; break;
            }
            switch (spThirdCard)
            {
                case "2": spHandStrength += 10; break;
                case "3": spHandStrength += 9; break;
                case "4": spHandStrength += 8; break;
                case "5": spHandStrength += 7; break;
                case "6": spHandStrength += 6; break;
                case "7": spHandStrength += 5; break;
                case "8": spHandStrength += 4; break;
                case "9": spHandStrength += 3; break;
                case "10": spHandStrength += 2; break;
                case "A": spHandStrength += 1; break;
                case "J": spHandStrength += 11; break;
                case "Q": spHandStrength += 12; break;
                case "K": spHandStrength += 13; break;               
                case "Z": spTotalScore *= 2; break;
                case "Y": spTotalScore -= 200; break;
            }
         
            if ((fpFirstCard == "X" || fpSecondCard == "X" || fpThirdCard == "X") 
             && (spFirstCard != "X" && spSecondCard != "X" && spThirdCard != "X"))
            {
                 Console.WriteLine("X card drawn! Player one wins the match!");
                 matchWon = true;
                 break;
            }
            else if ((spFirstCard == "X" || spSecondCard == "X" || spThirdCard == "X") 
                  && (fpFirstCard != "X" && fpSecondCard != "X" && fpThirdCard != "X"))
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                matchWon = true;
                break;
            }
            else if ((fpFirstCard == "X" || fpSecondCard == "X" || fpThirdCard == "X") 
                  && (spFirstCard == "X" || spSecondCard == "X" || spThirdCard == "X"))
            {
                fpTotalScore += 50;
                spTotalScore += 50;                
            }
            
            if (fpHandStrength > spHandStrength)
            {
                fpGamesWon++;
                fpTotalScore += fpHandStrength;
            }
            else if (spHandStrength > fpHandStrength)
            {
                spGamesWon++;
                spTotalScore += spHandStrength;
            }
                                                                                     
            fpHandStrength = 0;
            spHandStrength = 0;
        }

        if (fpTotalScore > spTotalScore && matchWon == false)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", fpTotalScore);
            Console.WriteLine("Games won: {0}", fpGamesWon);
        }
        else if (spTotalScore > fpTotalScore && matchWon == false)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", spTotalScore);
            Console.WriteLine("Games won: {0}", spGamesWon);
        }
        else if (fpTotalScore == spTotalScore && matchWon == false)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", fpTotalScore);
        }
    }
}