using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 1; i <= n; i++)
        {
            int numbers1 = int.Parse(Console.ReadLine());
            sum1 = sum1 + numbers1;
        }

        for (int i = 1; i <=n; i++)
        {
            int numbers2 = int.Parse(Console.ReadLine());
            sum2 = sum2 + numbers2;
        }

        int diff = Math.Abs(sum1 - sum2);

        if (sum1==sum2)
        {
            Console.WriteLine("Yes, sum=" + sum1);
        }
        else
        {
            Console.WriteLine("No, diff=" + diff);
        }
    }
}

