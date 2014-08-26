using System;

class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());
        int digitsSum = 0;            
        int[] letters = {10, 20, 30, 50, 80, 110, 130, 160, 200, 240};
        int counter = 0;
           
        for (int d1 = 0; d1 <= 9; d1++)
        {
            for (int d2 = 0; d2 <= 9; d2++)
            {
                for (int d3 = 0; d3 <= 9; d3++)
                {
                    for (int d4 = 0; d4 <= 9; d4++)
                    {
                        for (int d5 = 0; d5 < letters.Length; d5++)
                        {
                            for (int d6 = 0; d6 < letters.Length; d6++)
                            {
                                if ((d1==d2 && d2==d3 && d3==d4) || (d2==d3 && d3==d4) || (d1==d2 && d2==d3) 
                                    || (d1==d2 && d3==d4) || (d1==d3 && d2==d4) || (d1==d4 && d2==d3))
                                {
                                    digitsSum = d1 + d2 + d3 + d4 + letters[d5] + letters[d6];
                                }
                                                                
                                if (digitsSum + 40 == magicWeight)
                                {
                                    counter++;
                                }
                            }
                        }                          
                    }
                }
            }
        }
         
        Console.WriteLine(counter);
    }
}
