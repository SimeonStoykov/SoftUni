using System;
using System.Globalization;
using System.Threading;

class OddEvenElements
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        string input = Console.ReadLine();
        string[] numbers = input.Split();
        double evenSum = 0;
        double oddSum = 0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;

        if (input == "")
        {
            numbers = new string[0];
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i%2!=0)
            {
                evenSum += double.Parse(numbers[i]);
                   
                if (double.Parse(numbers[i])>evenMax)
                {
                    evenMax=double.Parse(numbers[i]);                        
                }
                if (double.Parse(numbers[i])<evenMin)
                {
                    evenMin=double.Parse(numbers[i]);                       
                }                    
            }
            else
            {
                oddSum += double.Parse(numbers[i]);
                    
                if (double.Parse(numbers[i]) > oddMax)
                {
                    oddMax = double.Parse(numbers[i]);                       
                }
                if (double.Parse(numbers[i]) < oddMin)
                {
                    oddMin = double.Parse(numbers[i]);                        
                }
            }                
        }
            
        if (numbers.Length==1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", 
                              Math.Round(oddSum, 2), Math.Round(oddMin, 2), Math.Round(oddMax, 2));
        }  
        else if (numbers.Length==0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", 
                              Math.Round(oddSum,2), Math.Round(oddMin,2), Math.Round(oddMax,2), Math.Round(evenSum,2), 
                              Math.Round(evenMin,2), Math.Round(evenMax,2));
        }            
    }
}