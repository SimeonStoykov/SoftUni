using System;

class AgeIn10Years
{
    static void Main()
    {
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        int ageNow = DateTime.Now.Year - birthday.Year;
        int ageIn10Years = ageNow + 10;
        Console.WriteLine("Your age now is: " + ageNow);
        Console.WriteLine("Your age in 10 years will be: " + ageIn10Years);
    }
}