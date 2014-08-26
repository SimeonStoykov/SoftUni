using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("This number is prime = False");
        }
        else
        {
            int primeCount = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    primeCount++;
                }
            }

            bool isPrime = true;

            if (primeCount > 2)
            {
                isPrime = false;
            }

            Console.WriteLine("This number is prime = " + isPrime);
        } 

        //ALTERNATIVE SOLUTION

        //int number = int.Parse(Console.ReadLine());
        //bool isPrime = true;
        //if (number <= 1)
        //{
        //    isPrime = false;
        //}
        //else
        //{
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            isPrime = false;
        //        }
        //    }
        //}       
        //Console.WriteLine(isPrime);
    }
}


