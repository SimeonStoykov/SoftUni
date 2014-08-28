using System;

class Tables
{
    static void Main()
    {
        long legs1 = long.Parse(Console.ReadLine()) * 1;
        long legs2 = long.Parse(Console.ReadLine()) * 2;
        long legs3 = long.Parse(Console.ReadLine()) * 3;
        long legs4 = long.Parse(Console.ReadLine()) * 4;
        int T = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        long allLegs = legs1 + legs2 + legs3 + legs4;
        long tablesByLegs = allLegs / 4;
        long tablesByTops = T;
        long tablesMade = 0;
        long legsNeeded = 0;
        
        if (tablesByLegs>T)
        {
            tablesMade = T;
        }
        else if (tablesByLegs<T)
        {
            tablesMade = tablesByLegs;
        }
        else if (tablesByLegs == T)
        {
            tablesMade = T;
        }

        if (allLegs/4 >= N)
        {
            legsNeeded = 0;
        }
        else if (allLegs/4 < N)
        {
            legsNeeded = N * 4 - allLegs;
        }

        if (tablesMade==N)
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }
        else if (tablesMade>N)
        {
            Console.WriteLine("more: {0}", tablesMade - N);
            Console.WriteLine("tops left: {0}, legs left: {1}", tablesMade-N, allLegs - N*4);
        }
        else if (N>tablesMade)
        {
            Console.WriteLine("less: {0}", tablesMade-N);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", N-tablesMade, legsNeeded);
        }
    }
}