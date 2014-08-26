using System;

class TrailingZeroes
{
    static void Main()
    {            
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 5; n / i >= 1; i *= 5)
        {
            count += n / i;
        }

        Console.WriteLine(count);                
    }
}

//ALTERNATIVE SOLUTION (SLOWER)

//int n = int.Parse(Console.ReadLine());
//BigInteger factoriel = 1;
//int counter = 0;
//for (int i = 1; i <=n; i++)
//{
//    factoriel *= i;
//}            

//while (true)
//{
//    if (factoriel%10==0)
//    {
//        counter++;
//        factoriel = factoriel / 10;
//    }
//    else
//    {
//        break;
//    }
//}            
//Console.WriteLine(counter);
