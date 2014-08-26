using System;

class SumOf5Numbers
{
    static void Main()
    {        
        string[] userINput = Console.ReadLine().Split();
        double a = Convert.ToDouble(userINput[0]);
        double b = Convert.ToDouble(userINput[1]);
        double c = Convert.ToDouble(userINput[2]);
        double d = Convert.ToDouble(userINput[3]);
        double e = Convert.ToDouble(userINput[4]);
                
        double sumOfAll = a + b + c + d + e;
        Console.WriteLine(sumOfAll);       
    }
}

