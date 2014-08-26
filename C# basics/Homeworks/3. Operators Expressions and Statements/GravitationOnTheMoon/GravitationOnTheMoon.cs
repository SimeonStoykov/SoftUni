using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter weight: ");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("Weight on Moon is: " + weightOnMoon );
    }
}
