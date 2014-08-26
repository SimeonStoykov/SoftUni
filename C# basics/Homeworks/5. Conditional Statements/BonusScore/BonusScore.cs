using System;

class BonusScore
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n>=1 && n<=3)
        {
            n = n * 10;
            Console.WriteLine(n);
        }
        else if (n>=4 && n<=6)
        {
            n = n * 100;
            Console.WriteLine(n);
        }
        else if (n>=7 && n<=9)
        {
            n = n * 1000;
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("Invalid score!");
        }
    }
}

