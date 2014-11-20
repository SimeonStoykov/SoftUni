using System;

class SevenlandNumbers
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int nextK = 0;

        switch (K)
        {
            case 66:  nextK = 100; break;
            case 166: nextK = 200; break;
            case 266: nextK = 300; break;
            case 366: nextK = 400; break;
            case 466: nextK = 500; break;
            case 566: nextK = 600; break;
            case 666: nextK = 1000; break;
        }

        if (K>=0 && K < 666 && K != 66 && K != 166 && K != 266 && K != 366 && K != 466 && K != 566)
        {
            if (K % 10 == 6)
            {
                nextK = K + 4;
            }
            else
            {
                nextK = K + 1;
            }
        }
                      
        Console.WriteLine(nextK);
    }
}