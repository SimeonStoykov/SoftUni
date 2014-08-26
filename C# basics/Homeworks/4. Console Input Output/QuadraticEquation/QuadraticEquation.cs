using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double D = b * b - 4 * a * c;
        double x1=(-b+Math.Sqrt(D))/(2*a);
        double x2=(-b-Math.Sqrt(D))/(2*a);
        double x12 = -b / (2 * a);

        if (D>0)
        {
            Console.WriteLine("Two different real roots: x1={0} x2={1}", x1, x2);
        }
        else if (D==0)
        {
            Console.WriteLine("Two equal real roots: x1=x2={0}", x12);
        }
        else
        {
            Console.WriteLine("No real roots!");
        }
    }
}

