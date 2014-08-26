using System;

class AgeIn10Years
{
    static void Main()
    {
        int ageNow = int.Parse(Console.ReadLine());
        int ageIn10Years = ageNow + 10;
        Console.WriteLine("Your age now is: " + ageNow);
        Console.WriteLine("Your age in 10 years will be: " + ageIn10Years);
    }
}

