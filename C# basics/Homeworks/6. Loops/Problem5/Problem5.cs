/*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x^2 + … + n!/x^n. 
 * Use only one loop. Print the result with 5 digits after the decimal point.*/
using System;

class Problem5
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        double factoriel = 1;

        for (double i = 1; i <= n; i++)
        {
            factoriel *= i;
            double y = Math.Pow(x, i);
            sum = sum + (factoriel / y);
        }

        Console.WriteLine("{0:f5}", sum);
    }
}

