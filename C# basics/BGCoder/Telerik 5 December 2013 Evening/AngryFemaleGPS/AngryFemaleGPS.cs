using System;

class AngryFemaleGPS
{
    static void Main()
    {
        string number = Console.ReadLine();
        if (number[0] == '-')
        {
            number = number.Remove(0, 1);
        }

        int[] numsArr = new int[number.Length];
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            numsArr[i] = number[i] - 48; //48 is the value of char 0
        }

        for (int i = 0; i < numsArr.Length; i++)
        {
            if (numsArr[i] % 2 != 0)
            {
                oddSum += numsArr[i];
            }
            else
            {
                evenSum += numsArr[i];
            }
        }

        if (oddSum > evenSum)
        {
            Console.WriteLine("left {0}", oddSum);
        }
        else if (oddSum < evenSum)
        {
            Console.WriteLine("right {0}", evenSum);
        }
        else
        {
            Console.WriteLine("straight {0}", oddSum);
        }
    }
}


//ALTERNATIVE SOLUTION

//using System;

//class AngryFemaleGPS
//{
//  static void Main()
//  {
//    long N = long.Parse(Console.ReadLine().TrimStart('-'));

//    decimal sumEven = 0;
//    decimal sumOdd = 0;
//    int y = 0;

//    while (true)
//    {
//      y = (int) (N % 10);

//      if (y % 2 == 0)
//      {
//        sumEven = sumEven + y;
//      }
//      else
//      {
//        sumOdd = sumOdd + y;
//      }

//      N = N / 10;

//      if (N == 0)
//      {
//        break;  
//      }
//    }

//    if (sumEven == sumOdd)
//    {
//      Console.WriteLine("straight {0}",sumEven);
//    }
//    else if (sumEven > sumOdd)
//    {
//      Console.WriteLine("right {0}", sumEven);
//    }
//    else if(sumOdd > sumEven)
//    {
//      Console.WriteLine("left {0}", sumOdd);
//    }
//  }
//}