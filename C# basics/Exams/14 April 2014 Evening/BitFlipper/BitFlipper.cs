using System;

class BitFlipper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string numberStr = "";
        string sequence = "";

        while (number>0)            
        {
            sequence = ""+number % 2;
            number = number / 2;
            numberStr = sequence + numberStr;
        } 
         
        numberStr = numberStr.PadLeft(64, '0');
        char[] binary = numberStr.ToCharArray();           
           
        for (int i = 0; i < numberStr.Length-2;)
        {
            if (binary[i] == binary[i + 1] && binary[i + 1] == binary[i + 2])
            {                   
                if (binary[i] == '1')
                {
                    binary[i] = '0';
                    binary[i + 1] = '0';
                    binary[i + 2] = '0';
                }
                else 
                {
                    binary[i] = '1';
                    binary[i + 1] = '1';
                    binary[i + 2] = '1';
                }
                i = i + 3;                  
            }
            else
            {
                i++;
            }               
        }
         
        string[] flipped = Array.ConvertAll(binary, element => element.ToString());
        ulong[] flippedNumber = Array.ConvertAll(flipped, element => ulong.Parse(element));
        ulong sum = 0;
        int power = 0;

        for (int i = flippedNumber.Length-1; i >= 0; i--)
        {
            sum = sum + flippedNumber[i] * (ulong)Math.Pow(2, power);
            power++;
        }

        Console.WriteLine(sum);        
    }        
}

