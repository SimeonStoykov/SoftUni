using System;

class PointsInAndOut
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double r = 1.5;
        if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= r * r && x > -0.5 && x < 2.5 && y > 1)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        //ALTERNATIVE SOLUTION

        //Console.Write("X = ");
        //double x = double.Parse(Console.ReadLine());
        //Console.Write("Y = ");
        //double y = double.Parse(Console.ReadLine());
        //double r = 1.5;
        //bool isInCircle = r * r >= (x - 1) * (x - 1) + (y - 1) * (y - 1);
        //bool isInRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);
        //Console.WriteLine(isInCircle && !isInRectangle ? "yes" : "no");           
    }
}