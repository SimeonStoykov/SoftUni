using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        int oddProd = 1;
        int evenProd = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i%2==0)
            {
                oddProd *= int.Parse(numbers[i]);
            }
            else
            {
                evenProd *= int.Parse(numbers[i]);
            }
        }

        if (oddProd==evenProd)
        {
            Console.WriteLine("yes \nproduct = {0}", oddProd);
        }
        else
        {
            Console.WriteLine("no \nodd_product = {0} \neven_product = {1}", oddProd,evenProd);
        }
    }
}

