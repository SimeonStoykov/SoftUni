using System;

class MelonsAndWatermelons
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int melon = 0;
        int watermelon = 0;
        int melonAmount = 0;
        int watermelonAmount = 0;
        int remainder = (d + start) - start;
                         
        for (int i = 1; i <= 7; i++)
        {                
            if (remainder==0)
            {
                break;
            }
            if (remainder == (d + start) - start)
            {
                i = start;                    
            }
            switch (i)
            {
                case 1: watermelon = 1; melon = 0; break;
                case 2: watermelon = 0; melon = 2; break;
                case 3: watermelon = 1; melon = 1; break;
                case 4: watermelon = 2; melon = 0; break;
                case 5: watermelon = 2; melon = 2; break;
                case 6: watermelon = 1; melon = 2; break;
                case 7: watermelon = 0; melon = 0; break;
            }

            melonAmount = melonAmount + melon;
            watermelonAmount = watermelonAmount + watermelon;               
            remainder--;

            if (i == 7)
            {
                i = 0;
            }                              
        }

        if (melonAmount==watermelonAmount)
        {
            Console.WriteLine("Equal amount: {0}", melonAmount);
        }
        else if (melonAmount>watermelonAmount)
        {
            Console.WriteLine("{0} more melons", melonAmount-watermelonAmount);
        }
        else
        {
            Console.WriteLine("{0} more watermelons", watermelonAmount - melonAmount);
        }
    }
}

