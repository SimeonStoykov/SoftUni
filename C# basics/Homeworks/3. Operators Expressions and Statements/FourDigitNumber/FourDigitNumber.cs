using System;

class FourDigitNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int char4 = n% 10;
        int char3 = (n%100) / 10;
        int char2 = (n%1000) / 100;
        int char1 = (n%10000)/1000;
        int sum = char1 + char2 + char3 + char4;
        Console.WriteLine(sum);
        string d = char4.ToString();
        string c = char3.ToString();
        string b = char2.ToString();
        string a = char1.ToString();
        Console.WriteLine(d + c+ b+ a);
        Console.WriteLine(d + a + b + c);
        Console.WriteLine(a + c + b + d);            
    }
}

