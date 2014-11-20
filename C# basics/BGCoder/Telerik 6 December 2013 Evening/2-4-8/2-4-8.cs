using System;

class TwoFourEight
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long result = 0;

        switch (B)
        {
            case 2: result = A % C; break;
            case 4: result = A + C; break;
            case 8: result = A * C; break;            
        }

        long originalResult = result;
        if (result % 4 == 0)
        {
            result /= 4;
        }
        else
        {
            result %= 4;
        }

        Console.WriteLine(result);
        Console.WriteLine(originalResult);
    }
}