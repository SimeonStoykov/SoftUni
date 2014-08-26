using System;

class CountingWordsInText
{
    static int CompareWords(string inputWord, string inputText)
    {
        string[] allWords = inputText.Split(
            new char[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')' },
            StringSplitOptions.None);

        int counter = 0;

        for (int i = 0; i < allWords.Length; i++)
        {
            //string.Equals give better options to compare strings (like ignore casing)
            if (string.Equals(allWords[i], inputWord, StringComparison.OrdinalIgnoreCase))
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        string keyWord = Console.ReadLine();
        string someText = Console.ReadLine();

        int result = CompareWords(keyWord, someText);
        Console.WriteLine(result);
    }
}