using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        double avTimeD = d * 0.9 * 12 * p/100;
        int avTime = (int)avTimeD;

        if (h>avTime)
        {
            Console.WriteLine("No");
            Console.WriteLine(avTime-h);
        }
        else if (h<=avTime)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(avTime-h);
        }
    }
}

