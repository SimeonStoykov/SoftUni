using System;

class LongestWordInText
{
    static void Main()
    {            
        string[] text = Console.ReadLine().Trim('.').Split();           
        int max = 0;
        string maxWord = "";

        for (int i = 0; i < text.Length; i++)
        {
            int word = text[i].Length;
            if (word > max)
            {
                max = word;
                maxWord = text[i];
            }
        }

        Console.WriteLine(maxWord);
    }
}

