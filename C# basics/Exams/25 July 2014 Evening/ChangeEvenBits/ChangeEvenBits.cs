using System;

class ChangeEvenBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string bitsCountStr = "";
        int bitsCounter = 0;       
        ulong one = 1;                     
        int maxCounter = 0;
       
        for (int i = 0; i < n; i++)
        {
                ushort numberBitsCount = ushort.Parse(Console.ReadLine());
                bitsCountStr = Convert.ToString(numberBitsCount, 2);
                for (int bit = 0; bit < bitsCountStr.Length; bit++)
                {
                    bitsCounter++;
                }               
                if (bitsCounter > maxCounter)
                {
                    maxCounter = bitsCounter;                    
                }
                bitsCounter = 0;
                bitsCountStr = "";         
        }

        int counter = 0;
        ulong numberToChange = ulong.Parse(Console.ReadLine());
        ulong originalNumer = numberToChange;

        for (int evenBits = 0; evenBits < maxCounter * 2; evenBits += 2)
        {
            ulong mask = one << evenBits;            
            numberToChange = numberToChange | mask;            
        }

        for (int evenBits = 0; evenBits < maxCounter * 2; evenBits += 2)
        {
            ulong numberToChangeRight = originalNumer >> evenBits;
            ulong haveZero = numberToChangeRight & 1;
            if (haveZero == 0)
            {
                counter++;
            }
        }

        Console.WriteLine(numberToChange);
        Console.WriteLine(counter);    
    }
}

