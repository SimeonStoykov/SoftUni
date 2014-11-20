using System;
class Program
{
    static void Main()
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int pointOfHit = fx + d;
        int damage = 0;
        int temp;

        if (px1 > px2)
        {
            temp = px1;
            px1 = px2;
            px2 = temp;
            temp = py1;
            py1 = py2;
            py2 = temp;
        }
        if (py1 > py2)
        {
            temp = py1;
            py1 = py2;
            py2 = temp;
        }
        // check if pointOfHit (impact) is inside plant
        if (pointOfHit >= px1 && pointOfHit <= px2 && fy >= py1 && fy <= py2)
        {
            damage += 100;
        }
        // check if pointOfHit+1 (the 75% point) is inside plant
        if ((pointOfHit + 1) >= px1 && (pointOfHit + 1) <= px2 && fy >= py1 && fy <= py2)
        {
            damage += 75;
        }
        //check if 50% points (above and below impact/poitOfHit) are inside plant
        if (pointOfHit >= px1 && pointOfHit <= px2)
        {
            if (fy == py1 - 1 || fy == py2 + 1)
            {
                damage += 50;
            }
            else if (fy > py1 && fy < py2)
            {
                damage += 100;
            }
            else if ((fy == py1 || fy == py2) && (py2 - py1 > 0))
            {
                damage += 50;
            }
        }
        Console.WriteLine("{0}%", damage);
    }
}