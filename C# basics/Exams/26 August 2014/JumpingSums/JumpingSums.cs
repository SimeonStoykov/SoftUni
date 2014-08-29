using System;
using System.Linq;

class JumpingSums
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int jumps = int.Parse(Console.ReadLine());
        int jumpsCount = jumps;
        int tempSum = 0;
        int maxSum = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            tempSum = 0;
            int oldI = i;            
            jumps = jumpsCount;

            while (jumps > 0)
            {                
                int nextIndex = i + numbers[i];

                if (jumps == jumpsCount)
                {
                    if (nextIndex > numbers.Length - 1)
                    {
                        while (nextIndex > numbers.Length - 1)
                        {
                            nextIndex = nextIndex - numbers.Length;
                        }
                    }
                    tempSum += numbers[i] + numbers[nextIndex];
                }
                else
                {
                    if (nextIndex > numbers.Length - 1)
                    {
                        while (nextIndex > numbers.Length - 1)
                        {
                            nextIndex = nextIndex - numbers.Length;
                        }                       
                    }
                    tempSum += numbers[nextIndex];
                }              
                i = nextIndex;
                jumps--;
            }

            if (tempSum > maxSum)
            {
                maxSum = tempSum;
            }

            i = oldI;            
        }
                              
        Console.WriteLine("max sum = {0}", maxSum);
    }
}