using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int evenSum = 0;
        int oddSum = 0;

        for (int i = 1; i <=2*n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i%2==0)
            {
                evenSum += number; 
            }
            else
            {
                oddSum += number;
            }
        }

        int diff = Math.Abs(evenSum - oddSum);

        if (evenSum==oddSum)
        {
            Console.WriteLine("Yes, sum=" + evenSum);
        }
        else
        {
            Console.WriteLine("No, diff=" + diff);
        }
    }
}

