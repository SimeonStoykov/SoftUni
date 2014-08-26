using System;

class CrossingSequences
{
    static void Main()
    {
        int firstTrib = int.Parse(Console.ReadLine());
        int secondTrib = int.Parse(Console.ReadLine());
        int thirdTrib = int.Parse(Console.ReadLine());

        int firstSpir = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        bool[] isTrib = new bool[1000000+1];

        isTrib[firstTrib] = true;
        isTrib[secondTrib] = true;
        isTrib[thirdTrib] = true;

        bool isOk = false;
        int fourthTrib = 0;

        while (true)
        {
            fourthTrib = firstTrib + secondTrib + thirdTrib;
            firstTrib = secondTrib;
            secondTrib = thirdTrib;
            thirdTrib = fourthTrib;

            if (fourthTrib>1000000)
            {
                break;
            }
            isTrib[thirdTrib] = true;              
        }

        int counter = 1;
        while (firstSpir<=1000000)
        {     
            if (isTrib[firstSpir]==true)
            {
                isOk = true;
                Console.WriteLine(firstSpir);
                break;
            }
            firstSpir += step * (counter / 2);
            counter++;
        }

        if (isOk==false)
        {
            Console.WriteLine("No");
        }
    }
}


