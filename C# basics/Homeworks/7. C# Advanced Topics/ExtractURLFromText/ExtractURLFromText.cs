using System;
using System.Text.RegularExpressions;

class ExtractURLFromText
{
    static void Main()
    {
        string text = Console.ReadLine();
        Regex linkParser = new Regex(@"\b(?:http://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        Console.WriteLine();

        foreach (Match link in linkParser.Matches(text))
        {
            Console.WriteLine(link.Value);
        }                           
    }
}

