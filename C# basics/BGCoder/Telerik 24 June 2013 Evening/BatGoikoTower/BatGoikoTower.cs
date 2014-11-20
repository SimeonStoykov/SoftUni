using System;

class BatGoikoTower
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int outerDots = height - 1;
        int innerDots = 0;
        int dashRow = 2;
        int counter = 2;
        int dashes = 0;

        for (int row = 1; row <= height; row++)
        {
            if (row == dashRow)
            {
                Console.WriteLine(new String('.', outerDots) + '/' + new String('-', dashes)
                                + '\\' + new String('.', outerDots));
                dashRow += counter;
                counter++;
            }
            else
            {
                Console.WriteLine(new String('.', outerDots) + '/' + new String('.', innerDots) 
                                + '\\' + new String('.', outerDots));
            }           
            dashes += 2;
            innerDots += 2;
            outerDots--;           
        }
    }
}