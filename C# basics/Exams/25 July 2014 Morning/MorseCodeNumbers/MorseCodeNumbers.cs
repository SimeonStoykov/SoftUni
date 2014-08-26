using System;

class MorseCodeNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());            
        int d1 = (number / 1000) % 10;
        int d2 = (number / 100) % 10;
        int d3 = (number / 10) % 10;
        int d4 = (number / 1) % 10;
        int sumN = d1 + d2 + d3 + d4;
        int counter = 0;
        string[] codes = {"-----", ".----" , "..---", "...--", "....-", "....."};
        
        for (int dig1 = 0; dig1 <= 5; dig1++)
        {
            for (int dig2 = 0; dig2 <= 5; dig2++)
            {
                for (int dig3 = 0; dig3 <= 5; dig3++)
                {
                    for (int dig4 = 0; dig4 <= 5; dig4++)
                    {
                        for (int dig5 = 0; dig5 <= 5; dig5++)
                        {
                            for (int dig6 = 0; dig6 <= 5; dig6++)
                            {
                              int product = dig1 * dig2 * dig3 * dig4 * dig5 * dig6;
                              
                                if (sumN==product)
                                {
                                    Console.WriteLine(codes[dig1] + "|" + codes[dig2] + "|" + codes[dig3] + "|" 
                                                    + codes[dig4] + "|" + codes[dig5] + "|" + codes[dig6] + "|");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (counter==0)
        {
            Console.WriteLine("No");
        }
    }
}

