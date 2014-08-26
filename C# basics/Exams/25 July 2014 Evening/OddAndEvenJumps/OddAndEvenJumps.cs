using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class OddAndEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        ulong oddResult = 0;
        ulong evenResult = 0;
        input = input.ToLower();
        input = input.Replace(" ", ""); //input = Regex.Replace(input, "\\s+", "");

        char[] letters = input.ToCharArray();

        List<char> oddChars = new List<char>();
        oddChars.Add('0'); //add char to position 0 so we can start adding letters from 1 in the list
        List<char> evenChars = new List<char>();
        evenChars.Add('0');

        for (int i = 0; i < letters.Length; i++)
        {
            if (i%2==0) //odd number
            {
                oddChars.Add(letters[i]);
            }
            else //even number
            {
                evenChars.Add(letters[i]);
            }
        }

        for (int i = 1; i < oddChars.Count; i++)
        {          
            if (i%oddJump==0)
            {
                oddResult = oddResult * oddChars[i];
            }
            else
            {
                oddResult += oddChars[i];
            }             
        }

        for (int i = 1; i < evenChars.Count; i++)
        {
            if (i % evenJump == 0)
            {
                evenResult = evenResult * evenChars[i];
            }
            else
            {
                evenResult += evenChars[i];
            }
        }

        Console.WriteLine("Odd: {0:X} \nEven: {1:X}", oddResult, evenResult);                
    }
}