﻿using System;
using System.Collections.Generic;
using System.Linq;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());

        string[] letters = {"s", "n", "k", "p"};
        int[] numbers = {3, 4, 1, 5};
        List<string> comb = new List<string>();

        for (int i1 = 0; i1 < 4; i1++)
        {
            for (int i2 = 0; i2 < 4; i2++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    for (int i4 = 0; i4 < 4; i4++)
                    {
                        for (int i5 = 0; i5 < 4; i5++)
                        {
                            for (int i6 = 0; i6 < 4; i6++)
                            {
                                for (int i7 = 0; i7 < 4; i7++)
                                {
                                    for (int i8 = 0; i8 < 4; i8++)
                                    {
                                        int leftSum = numbers[i1] + numbers[i2] + numbers[i3] + numbers[i4];
                                        int rightSum = numbers[i5] + numbers[i6] + numbers[i7] + numbers[i8];

                                        if (Math.Abs(leftSum-rightSum)==diff)
                                        {
                                            string combinations = letters[i1] + letters[i2] + letters[i3] + letters[i4] 
                                                                 + letters[i5]+ letters[i6] + letters[i7] + letters[i8];
                                            comb.Add(combinations);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (comb.Count()==0)
        {
            Console.WriteLine("No");
        }
        else
        {
            comb.Sort();
            foreach (string s in comb)
            {
                Console.WriteLine(s);
            }
        }
    }
}

