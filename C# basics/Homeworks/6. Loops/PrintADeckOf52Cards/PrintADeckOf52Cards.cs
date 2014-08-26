using System;

class PrintDeckOf52
{
    static void Main()
    {
        string card = "";

        for (int i = 2; i <= 14; i++)
        {
            if (i <= 10)
            {
                Console.Write(i);
                card = Convert.ToString(i);
            }
            else if (i == 11)
            {
                card = "J";
                Console.Write(card);
            }
            else if (i == 12)
            {
                card = "Q";
                Console.Write(card);
            }
            else if (i == 13)
            {
                card = "K";
                Console.Write(card);
            }
            else if (i == 14)
            {
                card = "A";
                Console.Write(card);
            }

            for (int face = 1; face <= 4; face++)
            {
                switch (face)
                {
                    case 1:
                        Console.Write("♣ ");
                        Console.Write(card);
                        break;
                    case 2:
                        Console.Write("♦ ");
                        Console.Write(card);
                        break;
                    case 3:
                        Console.Write("♥ ");
                        Console.Write(card);
                        break;
                    case 4:
                        Console.WriteLine("♠");
                        break;
                }
            }
        }
    }
}

//ALTERNATIVE SOLUTION

//using System;

//class PrintADeckOfPlayCards
//{
//    static void Main()
//    {
//        string[] facesCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
//        string[] colorsCards = { "♣", "♦", "♥", "♠" };

//        Console.WriteLine("Standart deck of 52 play cards contain:");
//        Console.WriteLine();
//        foreach (var face in facesCards)
//        {
//            foreach (var color in colorsCards)
//            {
//                Console.Write("{0}{1} ", face, color);
//            }
//            Console.WriteLine();
//        }
//    }
//}