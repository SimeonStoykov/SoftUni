using System;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimal = Console.ReadLine();
        List<string> numbers = new List<string>();

        for (int i = 0; i < hexadecimal.Length; i++)
        {                
            numbers.Add(hexadecimal[i].ToString());
        }
            
        int power = hexadecimal.Length - 1;
        long number = 0;
           
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            if (numbers[i]=="A")
            {
                numbers[i] = Convert.ToString(10);                    
            }
            if (numbers[i] == "B")
            {
                numbers[i] = Convert.ToString(11);
            }
            if (numbers[i] == "C")
            {
                numbers[i] = Convert.ToString(12);
            }
            if (numbers[i] == "D")
            {
                numbers[i] = Convert.ToString(13);
            }
            if (numbers[i] == "E")
            {
                numbers[i] = Convert.ToString(14);
            }
            if (numbers[i] == "F")
            {
                numbers[i] = Convert.ToString(15);
            }

            number = number + Convert.ToInt32(numbers[i]) * (long)Math.Pow(16, power);
            power--;
        }
        Console.WriteLine(number);
    }
}

