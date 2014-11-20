using System;

class PeaceOfCake
{
    static void Main()
    {
        decimal A = decimal.Parse(Console.ReadLine());
        decimal B = decimal.Parse(Console.ReadLine());
        decimal C = decimal.Parse(Console.ReadLine());
        decimal D = decimal.Parse(Console.ReadLine());

        decimal denominator = B * D;

        decimal newA = A * denominator / B;
        decimal newC = C * denominator / D;
        decimal nominator = newA + newC;
        decimal cakes = nominator/denominator;

        if (nominator >= denominator)
        {
            Console.WriteLine("{0}", (int)cakes);
        }
        else
        {
            Console.WriteLine("{0:f22}", cakes);
        }
        
       Console.WriteLine("{0}/{1}", nominator, denominator);
    }
}