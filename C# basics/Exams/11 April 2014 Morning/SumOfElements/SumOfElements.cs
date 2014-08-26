using System;

class SumOfElements
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
            
        long biggest = int.MinValue;
        long sum = 0;         
            
        for (int i = 0; i < numbers.Length; i++)
		{
			long number = long.Parse(numbers[i]);
            if (biggest < number)
            {
                biggest = number;
            }
            sum = sum + number;
		}  
    
        long diff = Math.Abs(sum-2*biggest);
        if (biggest*2==sum)
        {
            Console.WriteLine("Yes, sum="+biggest);
        }
        else 
        {
            Console.WriteLine("No, diff="+ diff);
        }
    }
}

