using System;

class ShipDamage
{
    static void Main()
    {
        int sX1 = int.Parse(Console.ReadLine());
        int sY1 = int.Parse(Console.ReadLine());
        int sX2 = int.Parse(Console.ReadLine());
        int sY2 = int.Parse(Console.ReadLine());
        int horizon = int.Parse(Console.ReadLine());
        int cX1 = int.Parse(Console.ReadLine());
        int cY1 = int.Parse(Console.ReadLine());
        int cX2 = int.Parse(Console.ReadLine());
        int cY2 = int.Parse(Console.ReadLine());
        int cX3 = int.Parse(Console.ReadLine());
        int cY3 = int.Parse(Console.ReadLine());

        int shipDamage = 0;

        int lowerY = int.MinValue;
        int higherY = int.MinValue;
        int lowerX = int.MinValue;
        int higherX = int.MinValue;

        if (sY1 > sY2)
        {
            lowerY = sY2;
            higherY = sY1;
        }
        else
        {
            lowerY = sY1;
            higherY = sY2;
        }

        if (sX1 > sX2)
        {
            lowerX = sX2;
            higherX = sX1;
        }
        else
        {
            lowerX = sX1;
            higherX = sX2;
        }

        if ((horizon - cY1 > lowerY - horizon && horizon - cY1 < higherY - horizon) && (cX1 > lowerX && cX1 < higherX))
        {
            shipDamage += 100;
        }
        if ((horizon - cY2 > lowerY - horizon && horizon - cY2 < higherY - horizon) && (cX2 > lowerX && cX2 < higherX))
        {
            shipDamage += 100;
        }
        if ((horizon - cY3 > lowerY - horizon && horizon - cY3 < higherY - horizon) && (cX3 > lowerX && cX3 < higherX))
        {
            shipDamage += 100;
        }


        if ((horizon - cY1 == lowerY - horizon) && (cX1 > lowerX && cX1 < higherX))
        {
            shipDamage += 50;
        }
        if ((horizon - cY1 == higherY - horizon) && (cX1 > lowerX && cX1 < higherX))
        {
            shipDamage += 50;
        }
        if ((horizon - cY1 > lowerY - horizon && horizon - cY1 < higherY - horizon) && (cX1 == lowerX))
        {
            shipDamage += 50;
        }
        if ((horizon - cY1 > lowerY - horizon && horizon - cY1 < higherY - horizon) && (cX1 == higherX))
        {
            shipDamage += 50;
        }

        if ((horizon - cY2 == lowerY - horizon) && (cX2 > lowerX && cX2 < higherX))
        {
            shipDamage += 50;
        }
        if ((horizon - cY2 == higherY - horizon) && (cX2 > lowerX && cX2 < higherX))
        {
            shipDamage += 50;
        }
        if ((horizon - cY2 > lowerY - horizon && horizon - cY2 < higherY - horizon) && (cX2 == lowerX))
        {
            shipDamage += 50;
        }
        if ((horizon - cY2 > lowerY - horizon && horizon - cY2 < higherY - horizon) && (cX2 == higherX))
        {
            shipDamage += 50;
        }

        if ((horizon - cY3 == lowerY - horizon) && (cX3 > lowerX && cX3 < higherX))
        {
            shipDamage += 50;
        }
        if ((horizon - cY3 == higherY - horizon) && (cX3 > lowerX && cX3 < higherX))
        {
            shipDamage += 50;
        }
        if ((horizon - cY3 > lowerY - horizon && horizon - cY3 < higherY - horizon) && (cX3 == lowerX))
        {
            shipDamage += 50;
        }
        if ((horizon - cY3 > lowerY - horizon && horizon - cY3 < higherY - horizon) && (cX3 == higherX))
        {
            shipDamage += 50;
        }

        if ((horizon - cY1 == lowerY - horizon) && (cX1 == lowerX)) //left bottom corner
        {
            shipDamage += 25;
        }
        if ((horizon - cY1 == lowerY - horizon) && (cX1 == higherX)) // right bottom corner
        {
            shipDamage += 25;
        }
        if ((horizon - cY1 == higherY - horizon) && (cX1 == lowerX)) // left top corner
        {
            shipDamage += 25;
        }
        if ((horizon - cY1 == higherY - horizon) && (cX1 == higherX)) // right top corner
        {
            shipDamage += 25;
        }


        if ((horizon - cY2 == lowerY - horizon) && (cX2 == lowerX)) //left bottom corner
        {
            shipDamage += 25;
        }
        if ((horizon - cY2 == lowerY - horizon) && (cX2 == higherX)) // right bottom corner
        {
            shipDamage += 25;
        }
        if ((horizon - cY2 == higherY - horizon) && (cX2 == lowerX)) // left top corner
        {
            shipDamage += 25;
        }
        if ((horizon - cY2 == higherY - horizon) && (cX2 == higherX)) // right top corner
        {
            shipDamage += 25;
        }


        if ((horizon - cY3 == lowerY - horizon) && (cX3 == lowerX)) //left bottom corner
        {
            shipDamage += 25;
        }
        if ((horizon - cY3 == lowerY - horizon) && (cX3 == higherX)) // right bottom corner
        {
            shipDamage += 25;
        }
        if ((horizon - cY3 == higherY - horizon) && (cX3 == lowerX)) // left top corner
        {
            shipDamage += 25;
        }
        if ((horizon - cY3 == higherY - horizon) && (cX3 == higherX)) // right top corner
        {
            shipDamage += 25;
        }

        Console.WriteLine(shipDamage + "%");
    }
}