using System;

class Triangle
{
    static void Main()
    {
        int Ax = int.Parse(Console.ReadLine());
        int Ay = int.Parse(Console.ReadLine());
        int Bx = int.Parse(Console.ReadLine());
        int By = int.Parse(Console.ReadLine());
        int Cx = int.Parse(Console.ReadLine());
        int Cy = int.Parse(Console.ReadLine());

        double dAB = Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay));
        double dBC = Math.Sqrt((Cx - Bx) * (Cx - Bx) + (Cy - By) * (Cy - By));
        double dAC = Math.Sqrt((Cx - Ax) * (Cx - Ax) + (Cy - Ay) * (Cy - Ay));

        double halfP = (dAB + dBC + dAC) / 2;
        double area = Math.Sqrt(halfP * (halfP - dAB) * (halfP - dAC) * (halfP -dBC));

        if (dAB+dAC>dBC && dAC+dBC>dAB && dAB+dBC>dAC)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", dAB);
        }
    }
}

