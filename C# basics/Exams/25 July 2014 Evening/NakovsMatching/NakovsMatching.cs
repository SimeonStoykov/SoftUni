using System;

class NakovsMatching
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();
        int d = int.Parse(Console.ReadLine());
        int aRight = 0;
        int aLeft = 0;
        int bRight = 0;
        int bLeft = 0;
        int aWholeSum = 0;
        int bWholeSum = 0;
        int nakovs = 0;
        bool haveNakovs = false;

        char[] firstChars = firstWord.ToCharArray();
        char[] secondChars = secondWord.ToCharArray();

        for (int i = 0; i < firstChars.Length; i++)
        {
            aWholeSum += firstChars[i];
        }

        for (int i = 0; i < secondChars.Length; i++)
        {
            bWholeSum += secondChars[i];
        }

        int counterA = 0;
        int counterB = 0;
        string aLeftChars = "";
        string aRightChars = "";
        string bLeftChars = "";
        string bRightChars = "";
        int counterRemoveA = 1;
        int counterRemoveB = 1;

        for (int i = 0; i < firstChars.Length; i++)
        {
            aLeft = aLeft + firstChars[counterA];
            aLeftChars += firstChars[counterA];

            aRight = aWholeSum - aLeft;
            aRightChars = firstWord.Remove(0, counterRemoveA);

            counterRemoveA++;
            counterA++; 
           
            if (counterA > firstChars.Length - 1)
            {
                break;
            }

            bLeft = 0;
            bRight = 0;
            bLeftChars = "";
            bRightChars = "";

            for (int j = 0; j < secondChars.Length; j++)
            {
                bLeft = bLeft + secondChars[counterB];
                bLeftChars += secondChars[counterB];

                bRight = bWholeSum - bLeft;
                bRightChars = secondWord.Remove(0, counterRemoveB);

                counterRemoveB++;
                counterB++;

                if (counterRemoveB > secondChars.Length)
                {
                    counterRemoveB = 1;
                }
                if (counterB > secondChars.Length - 1)
                {
                    counterB = 0;
                    break;
                }

                nakovs = Math.Abs((aLeft) * (bRight) - (aRight) * (bLeft));
                if (nakovs <= d)
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", aLeftChars, aRightChars, bLeftChars,
                                      bRightChars, nakovs);
                    haveNakovs = true;
                }
            }
        }

        if (haveNakovs == false)
        {
            Console.WriteLine("No");
        }
    }
}
