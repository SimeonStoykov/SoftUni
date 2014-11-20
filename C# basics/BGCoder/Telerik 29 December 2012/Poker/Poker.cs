using System;

class Poker
{
    static void Main()
    {
        string firstCard = Console.ReadLine();
        string secondCard = Console.ReadLine();
        string thirdCard = Console.ReadLine();
        string fourthCard = Console.ReadLine();
        string fifthCard = Console.ReadLine();


        if (firstCard == secondCard && secondCard == thirdCard
         && thirdCard == fourthCard && fourthCard == fifthCard)
        {
            Console.WriteLine("Impossible");
        }
        else if ((firstCard == secondCard && secondCard == thirdCard && thirdCard == fourthCard)
                || (secondCard == thirdCard && thirdCard == fourthCard && fourthCard == fifthCard)
                || (firstCard == secondCard && secondCard == thirdCard && thirdCard == fifthCard)
                || (firstCard == secondCard && secondCard == fourthCard && fourthCard == fifthCard)
                || (firstCard == thirdCard && thirdCard == fourthCard && fourthCard == fifthCard))
        {
            Console.WriteLine("Four of a Kind");
        }
        else if ((firstCard == secondCard) && (thirdCard == fourthCard && fourthCard == fifthCard)
              || (firstCard == fifthCard) && (secondCard == thirdCard && thirdCard == fourthCard)
              || (firstCard == thirdCard) && (secondCard == fourthCard && fourthCard == fifthCard)
              || (firstCard == fourthCard) && (secondCard == thirdCard && thirdCard == fifthCard)
              || (secondCard == thirdCard) && (firstCard == fourthCard && fourthCard == fifthCard)
              || (secondCard == fourthCard) && (firstCard == thirdCard && thirdCard == fifthCard)
              || (secondCard == fifthCard) && (firstCard == thirdCard && thirdCard == fourthCard)
              || (thirdCard == fourthCard) && (firstCard == secondCard && secondCard == fifthCard)
              || (thirdCard == fifthCard) && (firstCard == secondCard && secondCard == fourthCard)
              || (fourthCard == fifthCard) && (firstCard == secondCard && secondCard == thirdCard))
        {
            Console.WriteLine("Full House");
        }
        else if (((firstCard == "A" || firstCard == "2" || firstCard == "3" || firstCard == "4" || firstCard == "5")
            && (secondCard == "A" || secondCard == "2" || secondCard == "3" || secondCard == "4" || secondCard == "5")
            && (thirdCard == "A" || thirdCard == "2" || thirdCard == "3" || thirdCard == "4" || thirdCard == "5")
            && (fourthCard == "A" || fourthCard == "2" || fourthCard == "3" || fourthCard == "4" || fourthCard == "5")
            && (fifthCard == "A" || fifthCard == "2" || fifthCard == "3" || fifthCard == "4" || fifthCard == "5")
            && (firstCard != secondCard) && (firstCard != thirdCard) && (firstCard != fourthCard) && (firstCard != fifthCard)
            && (secondCard != thirdCard) && (secondCard != fourthCard) && (secondCard != fifthCard) && (thirdCard != fourthCard)
            && (thirdCard != fifthCard) && (fourthCard != fifthCard))
            ||
            ((firstCard == "2" || firstCard == "3" || firstCard == "4" || firstCard == "5" || firstCard == "6")
            && (secondCard == "2" || secondCard == "3" || secondCard == "4" || secondCard == "5" || secondCard == "6")
            && (thirdCard == "2" || thirdCard == "3" || thirdCard == "4" || thirdCard == "5" || thirdCard == "6")
            && (fourthCard == "2" || fourthCard == "3" || fourthCard == "4" || fourthCard == "5" || fourthCard == "6")
            && (fifthCard == "2" || fifthCard == "3" || fifthCard == "4" || fifthCard == "5" || fifthCard == "6")
            && (firstCard != secondCard) && (firstCard != thirdCard) && (firstCard != fourthCard) && (firstCard != fifthCard)
            && (secondCard != thirdCard) && (secondCard != fourthCard) && (secondCard != fifthCard) && (thirdCard != fourthCard)
            && (thirdCard != fifthCard) && (fourthCard != fifthCard))
            ||
            ((firstCard == "3" || firstCard == "4" || firstCard == "5" || firstCard == "6" || firstCard == "7")
            && (secondCard == "3" || secondCard == "4" || secondCard == "5" || secondCard == "6" || secondCard == "7")
            && (thirdCard == "3" || thirdCard == "4" || thirdCard == "5" || thirdCard == "6" || thirdCard == "7")
            && (fourthCard == "3" || fourthCard == "4" || fourthCard == "5" || fourthCard == "6" || fourthCard == "7")
            && (fifthCard == "3" || fifthCard == "4" || fifthCard == "5" || fifthCard == "6" || fifthCard == "7")
            && (firstCard != secondCard) && (firstCard != thirdCard) && (firstCard != fourthCard) && (firstCard != fifthCard)
            && (secondCard != thirdCard) && (secondCard != fourthCard) && (secondCard != fifthCard) && (thirdCard != fourthCard)
            && (thirdCard != fifthCard) && (fourthCard != fifthCard))
            ||
            ((firstCard == "4" || firstCard == "5" || firstCard == "6" || firstCard == "7" || firstCard == "8")
            && (secondCard == "4" || secondCard == "5" || secondCard == "6" || secondCard == "7" || secondCard == "8")
            && (thirdCard == "4" || thirdCard == "5" || thirdCard == "6" || thirdCard == "7" || thirdCard == "8")
            && (fourthCard == "4" || fourthCard == "5" || fourthCard == "6" || fourthCard == "7" || fourthCard == "8")
            && (fifthCard == "4" || fifthCard == "5" || fifthCard == "6" || fifthCard == "7" || fifthCard == "8")
            && (firstCard != secondCard) && (firstCard != thirdCard) && (firstCard != fourthCard) && (firstCard != fifthCard)
            && (secondCard != thirdCard) && (secondCard != fourthCard) && (secondCard != fifthCard) && (thirdCard != fourthCard)
            && (thirdCard != fifthCard) && (fourthCard != fifthCard))
             ||
            ((firstCard == "5" || firstCard == "6" || firstCard == "7" || firstCard == "8" || firstCard == "9")
            && (secondCard == "5" || secondCard == "6" || secondCard == "7" || secondCard == "8" || secondCard == "9")
            && (thirdCard == "5" || thirdCard == "6" || thirdCard == "7" || thirdCard == "8" || thirdCard == "9")
            && (fourthCard == "5" || fourthCard == "6" || fourthCard == "7" || fourthCard == "8" || fourthCard == "9")
            && (fifthCard == "5" || fifthCard == "6" || fifthCard == "7" || fifthCard == "8" || fifthCard == "9")
            && (firstCard != secondCard) && (firstCard != thirdCard) && (firstCard != fourthCard) && (firstCard != fifthCard)
            && (secondCard != thirdCard) && (secondCard != fourthCard) && (secondCard != fifthCard) && (thirdCard != fourthCard)
            && (thirdCard != fifthCard) && (fourthCard != fifthCard))
             ||
            ((firstCard == "6" || firstCard == "7" || firstCard == "8" || firstCard == "9" || firstCard == "10")
            && (secondCard == "6" || secondCard == "7" || secondCard == "8" || secondCard == "9" || secondCard == "10")
            && (thirdCard == "6" || thirdCard == "7" || thirdCard == "8" || thirdCard == "9" || thirdCard == "10")
            && (fourthCard == "6" || fourthCard == "7" || fourthCard == "8" || fourthCard == "9" || fourthCard == "10")
            && (fifthCard == "6" || fifthCard == "7" || fifthCard == "8" || fifthCard == "9" || fifthCard == "10")
            && (firstCard != secondCard) && (firstCard != thirdCard) && (firstCard != fourthCard) && (firstCard != fifthCard)
            && (secondCard != thirdCard) && (secondCard != fourthCard) && (secondCard != fifthCard) && (thirdCard != fourthCard)
            && (thirdCard != fifthCard) && (fourthCard != fifthCard))
             ||
            ((firstCard == "7" || firstCard == "8" || firstCard == "9" || firstCard == "10" || firstCard == "J")
            && (secondCard == "7" || secondCard == "8" || secondCard == "9" || secondCard == "10" || secondCard == "J")
            && (thirdCard == "7" || thirdCard == "8" || thirdCard == "9" || thirdCard == "10" || thirdCard == "J")
            && (fourthCard == "7" || fourthCard == "8" || fourthCard == "9" || fourthCard == "10" || fourthCard == "J")
            && (fifthCard == "7" || fifthCard == "8" || fifthCard == "9" || fifthCard == "10" || fifthCard == "J")
            && (firstCard != secondCard) && (firstCard != thirdCard) && (firstCard != fourthCard) && (firstCard != fifthCard)
            && (secondCard != thirdCard) && (secondCard != fourthCard) && (secondCard != fifthCard) && (thirdCard != fourthCard)
            && (thirdCard != fifthCard) && (fourthCard != fifthCard))
             ||
            ((firstCard == "8" || firstCard == "9" || firstCard == "10" || firstCard == "J" || firstCard == "Q")
            && (secondCard == "8" || secondCard == "9" || secondCard == "10" || secondCard == "J" || secondCard == "Q")
            && (thirdCard == "8" || thirdCard == "9" || thirdCard == "10" || thirdCard == "J" || thirdCard == "Q")
            && (fourthCard == "8" || fourthCard == "9" || fourthCard == "10" || fourthCard == "J" || fourthCard == "Q")
            && (fifthCard == "8" || fifthCard == "9" || fifthCard == "10" || fifthCard == "J" || fifthCard == "Q")
            && (firstCard != secondCard) && (firstCard != thirdCard) && (firstCard != fourthCard) && (firstCard != fifthCard)
            && (secondCard != thirdCard) && (secondCard != fourthCard) && (secondCard != fifthCard) && (thirdCard != fourthCard)
            && (thirdCard != fifthCard) && (fourthCard != fifthCard))
             ||
            ((firstCard == "9" || firstCard == "10" || firstCard == "J" || firstCard == "Q" || firstCard == "K")
            && (secondCard == "9" || secondCard == "10" || secondCard == "J" || secondCard == "Q" || secondCard == "K")
            && (thirdCard == "9" || thirdCard == "10" || thirdCard == "J" || thirdCard == "Q" || thirdCard == "K")
            && (fourthCard == "9" || fourthCard == "10" || fourthCard == "J" || fourthCard == "Q" || fourthCard == "K")
            && (fifthCard == "9" || fifthCard == "10" || fifthCard == "J" || fifthCard == "Q" || fifthCard == "K")
            && (firstCard != secondCard) && (firstCard != thirdCard) && (firstCard != fourthCard) && (firstCard != fifthCard)
            && (secondCard != thirdCard) && (secondCard != fourthCard) && (secondCard != fifthCard) && (thirdCard != fourthCard)
            && (thirdCard != fifthCard) && (fourthCard != fifthCard))
             ||
            ((firstCard == "10" || firstCard == "J" || firstCard == "Q" || firstCard == "K" || firstCard == "A")
            && (secondCard == "10" || secondCard == "J" || secondCard == "Q" || secondCard == "K" || secondCard == "A")
            && (thirdCard == "10" || thirdCard == "J" || thirdCard == "Q" || thirdCard == "K" || thirdCard == "A")
            && (fourthCard == "10" || fourthCard == "J" || fourthCard == "Q" || fourthCard == "K" || fourthCard == "A")
            && (fifthCard == "10" || fifthCard == "J" || fifthCard == "Q" || fifthCard == "K" || fifthCard == "A")
            && (firstCard != secondCard) && (firstCard != thirdCard) && (firstCard != fourthCard) && (firstCard != fifthCard)
            && (secondCard != thirdCard) && (secondCard != fourthCard) && (secondCard != fifthCard) && (thirdCard != fourthCard)
            && (thirdCard != fifthCard) && (fourthCard != fifthCard))
            )
        {
            Console.WriteLine("Straight");
        }
        else if ((firstCard == secondCard && secondCard == thirdCard)
              || (firstCard == secondCard && secondCard == fourthCard)
              || (firstCard == secondCard && secondCard == fifthCard)
              || (firstCard == thirdCard && thirdCard == fourthCard)
              || (firstCard == thirdCard && thirdCard == fifthCard)
              || (firstCard == fourthCard && fourthCard == fifthCard)
              || (secondCard == thirdCard && thirdCard == fourthCard)
              || (secondCard == thirdCard && thirdCard == fifthCard)
              || (secondCard == fourthCard && fourthCard == fifthCard)
              || (thirdCard == fourthCard && fourthCard == fifthCard))
        {
            Console.WriteLine("Three of a Kind");
        }
        else if ((firstCard == secondCard && thirdCard == fourthCard)
              || (firstCard == secondCard && thirdCard == fifthCard)
              || (firstCard == secondCard && fourthCard == fifthCard)

              || (firstCard == thirdCard && secondCard == fourthCard)
              || (firstCard == thirdCard && secondCard == fifthCard)
              || (firstCard == thirdCard && fourthCard == fifthCard)

              || (firstCard == fourthCard && secondCard == thirdCard)
              || (firstCard == fourthCard && secondCard == fifthCard)
              || (firstCard == fourthCard && thirdCard == fifthCard)

              || (firstCard == fifthCard && secondCard == thirdCard)
              || (firstCard == fifthCard && secondCard == fourthCard)
              || (firstCard == fifthCard && thirdCard == fourthCard)

              || (secondCard == thirdCard && fourthCard == fifthCard)
              || (secondCard == fourthCard && thirdCard == fifthCard)
              || (secondCard == fifthCard && thirdCard == fourthCard))
        {
            Console.WriteLine("Two Pairs");
        }
        else if (firstCard == secondCard || firstCard == thirdCard || firstCard == fourthCard
         || firstCard == fifthCard || secondCard == thirdCard || secondCard == fourthCard
         || secondCard == fifthCard || thirdCard == fourthCard || thirdCard == fifthCard
         || fourthCard == fifthCard)
        {
            Console.WriteLine("One Pair");
        }
        else
        {
            Console.WriteLine("Nothing");
        }
    }
}

//ALTERNATIVE SOLUTION

//using System;
					
//public class Program
//{
//    public static void Main()
//    {
//        int[] cards = new int[13];
//        int pairs = 0;
//        string hand = "Nothing";
		
//        for (int i = 0; i < 5; i++)
//        {
//            string card = Console.ReadLine();
//            if (card == "A") { cards[0]++; };
//            if (card == "2") { cards[1]++; };
//            if (card == "3") { cards[2]++; };
//            if (card == "4") { cards[3]++; };
//            if (card == "5") { cards[4]++; };
//            if (card == "6") { cards[5]++; };
//            if (card == "7") { cards[6]++; };
//            if (card == "8") { cards[7]++; };
//            if (card == "9") { cards[8]++; };
//            if (card == "10") { cards[9]++; };
//            if (card == "J") { cards[10]++; };
//            if (card == "Q") { cards[11]++; };
//            if (card == "K") { cards[12]++; };
//        }
		
//        for (int i = 0; i < cards.Length; i++)
//        {
//            if (cards[i] == 2)
//            {
//                pairs++;
//            }
//        }
		
//        for (int i = 0; i < cards.Length; i++)
//        {
//            if (cards[i] == 5)
//            {
//                hand = "Impossible";
//            }
			
//            if (cards[i] == 4)
//            {
//                hand = "Four of a Kind";
//            }            
			
//            if (cards[i] == 3)
//            {
//                hand = "Three of a Kind";
//            }
			
//            if (cards[i] == 2)
//            {
//                hand = "One Pair";
//            }
			
//            if (pairs == 2)
//            {
//                hand = "Two Pairs";
//            }
			
//            if (cards[i] == 3 && pairs == 1)
//            {
//                hand = "Full House";
//                break;
//            }
//        }
		
//        for (int i = 0; i <= 8; i++)
//        {
//            if (
//                cards[i] == 1 &&
//                cards[i + 1] == 1 &&
//                cards[i + 2] == 1 &&
//                cards[i + 3] == 1 &&
//                cards[i + 4] == 1
//            )
//            {
//                hand = "Straight";   
//            }
//        }
		
//        if (
//            cards[0] == 1 &&
//            cards[9] == 1 &&
//            cards[10] == 1 &&
//            cards[11] == 1 &&
//            cards[12] == 1
//        )
//        {
//            hand = "Straight";
//        }
		
//        Console.WriteLine(hand);
//    }
//}
	