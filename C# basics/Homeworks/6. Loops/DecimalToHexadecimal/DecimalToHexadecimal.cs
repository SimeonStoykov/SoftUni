using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());           
        string hexadecimal = "";
        string helpStr = "";

        for (int i = 0; i < 16; i++)
        {
            if (number%16==15)
            {
                helpStr = "F";
            }
            else if (number % 16 == 14)
            {
                helpStr = "E";
            }
            else if (number % 16 == 13)
            {
                helpStr = "D";
            }
            else if (number % 16 == 12)
            {
                helpStr = "C";
            }
            else if (number % 16 == 11)
            {
                helpStr = "B";
            }
            else if (number % 16 == 10)
            {
                helpStr = "A";
            }
            else if (number % 16 == 9)
            {
                helpStr = "9";                  
            }
            else if (number % 16 == 8)
            {
                helpStr = "8";
            }
            else if (number % 16 == 7)
            {
                helpStr = "7";
            }
            else if (number % 16 == 6)
            {
                helpStr = "6";
            }
            else if (number % 16 == 5)
            {
                helpStr = "5";
            }
            else if (number % 16 == 4)
            {
                helpStr = "4";
            }
            else if (number % 16 == 3)
            {
                helpStr = "3";
            }
            else if (number % 16 == 2)
            {
                helpStr = "2";
            }
            else if (number % 16 == 1)
            {
                helpStr = "1";
            }
            else if (number % 16 == 0)
            {
                helpStr = "0";
            }

            hexadecimal = helpStr + hexadecimal;
            number = number / 16;                                
        }
        Console.WriteLine(hexadecimal);
    }
}

