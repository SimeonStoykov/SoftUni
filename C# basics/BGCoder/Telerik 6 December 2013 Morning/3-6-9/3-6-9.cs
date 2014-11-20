using System;

class ThreeSixNine
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long result = 0;

        switch (B)
        {
            case 3: result = A + C; break;
            case 6: result = A * C; break;
            case 9: result = A % C; break;
        }

        if (result % 3 == 0)
        {
            Console.WriteLine(result / 3);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(result % 3);
            Console.WriteLine(result);
        }
    }
}