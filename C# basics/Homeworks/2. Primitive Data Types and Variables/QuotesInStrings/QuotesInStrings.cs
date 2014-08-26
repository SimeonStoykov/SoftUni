using System;

class QuotesInStrings
{
    static void Main()
    {
        string number1 = "The \"use\" of quotations causes difficulties.";
        string number2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(number1);
        Console.WriteLine(number2);
    }
}
