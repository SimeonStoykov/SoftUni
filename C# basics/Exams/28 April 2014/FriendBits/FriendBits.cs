using System;
using System.Collections.Generic;

class FriendBits
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        string numberStr = Convert.ToString(number, 2).PadLeft(32,'0');
        char[] bits = new char[numberStr.Length + 1];

        for (int i = 0; i < numberStr.Length; i++)
        {
            bits[i] = numberStr[i];
        }

        bits[32] = '2';
        List<string> friendBits = new List<string>();
        List<string> aloneBits = new List<string>();           
        int counter = 1;

        for (int i = 0; i < bits.Length-1;  i++)
        {
            char prevBit = bits[i];               
            char nextBit = bits[i + 1];
              
            if (prevBit == nextBit)
            {
                counter++;
            }               
            else if (counter > 1 && prevBit != nextBit)
            {
                friendBits.Add(new String(prevBit, counter));
                counter = 1;
            }
            else
            {                   
                aloneBits.Add(prevBit.ToString());
            }                                      
        }

        string friendNumber = "";
        for (int i = 0; i < friendBits.Count; i++)
        {
            friendNumber = friendNumber + friendBits[i];
        }

        string aloneNumber = "";
        for (int i = 0; i < aloneBits.Count; i++)
        {
            aloneNumber = aloneNumber + aloneBits[i];
        }

        if (aloneNumber == string.Empty)
        {
            aloneNumber = "0";
        }

        Console.WriteLine(Convert.ToUInt32(friendNumber,2));
        Console.WriteLine(Convert.ToUInt32(aloneNumber, 2));          
    }
}

