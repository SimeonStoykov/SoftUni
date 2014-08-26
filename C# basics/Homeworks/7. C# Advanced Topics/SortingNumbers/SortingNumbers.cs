using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {           
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        Console.WriteLine();

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}

//ALTERNATIVE SOLUTION (with List)

//int n = int.Parse(Console.ReadLine());   
//List<int> numbers = new List<int>();

//for (int i = 0; i < n; i++)
//{
//    int number = int.Parse(Console.ReadLine());
//    numbers.Add(number);
//}

//numbers.Sort();
//Console.WriteLine();

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
