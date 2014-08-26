using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random r = new Random();
            
        for (int i = 0; i < n; i++)
        {
            int randomInt = r.Next(min, max + 1);
            Console.Write(randomInt + " ");
            if (i+1==n)
            {
                Console.WriteLine();
            }
        }            
    }
}

