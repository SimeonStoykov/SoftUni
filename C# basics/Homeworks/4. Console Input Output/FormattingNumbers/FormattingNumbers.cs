using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        string binaryA = Convert.ToString(a, 2).PadLeft(10, '0');

        if (a>=0 && a<=500)
        {
            Console.WriteLine("|{0, -10:X}|{1}|{2, 10:0.00}|{3, -10:0.000}|", a, binaryA, b, c);
        }
        else
        {
            Console.WriteLine("Invalid input for the first number!");
        }
    }
}

