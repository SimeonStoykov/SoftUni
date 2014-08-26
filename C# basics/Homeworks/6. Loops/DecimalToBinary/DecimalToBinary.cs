using System;

class DecimalToBinary
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());           
        string binary = "";
            
        for (int i = 0; i <= 63; i++)
		{
           binary = number % 2 +  binary;
           number = number / 2;                                			 
		}

        Console.WriteLine(binary);                                              
    }
}
    

