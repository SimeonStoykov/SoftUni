using System;
using System.Text;

class DrunkenNumbers
{
    static void Main()
    {
        int rounds = int.Parse(Console.ReadLine());
        ulong countMitko = 0;
        ulong countVladko = 0;
        for (int round = 0; round < rounds; round++)
        {
            string drunkenNumber = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < drunkenNumber.Length; i++)
            {
                if (drunkenNumber[i] >= '0' && drunkenNumber[i] <= '9')
                {
                    sb.Append(drunkenNumber[i]);
                }
            }
            drunkenNumber = sb.ToString().TrimStart(new Char[] { '0' });
            int length = drunkenNumber.Length / 2 + drunkenNumber.Length % 2;
            for (int index = 0; index < length; index++)
            {
                if (drunkenNumber[index] >= '0' && drunkenNumber[index] <= '9')
                {
                    countMitko += (ulong)(drunkenNumber[index] - '0');
                }
                if (drunkenNumber[drunkenNumber.Length - 1 - index] >= '0' 
                 && drunkenNumber[drunkenNumber.Length - 1 - index] <= '9')
                {
                    countVladko += (ulong)(drunkenNumber[drunkenNumber.Length - 1 - index] - '0');
                }
            }
        }
        if (countMitko > countVladko)
        {
            Console.WriteLine("M {0}", (countMitko - countVladko));
        }
        else if (countMitko < countVladko)
        {
            Console.WriteLine("V {0}", (countVladko - countMitko));
        }
        else
        {
            Console.WriteLine("No {0}", (countMitko + countVladko));
        }
    }
}

//using System;
//class DrunkenNumbers
//{
//    static void Main()
//    {
//        int rounds = int.Parse(Console.ReadLine());
//        int beersMitko = 0;
//        int beersVlado = 0;

//        for (int i = 1; i <= rounds; i++)
//        {
//            int drunkenNumber = int.Parse(Console.ReadLine());
//            drunkenNumber = Math.Abs(drunkenNumber); //Number could be negative
//            string drunkenStr = drunkenNumber.ToString();

//            switch (drunkenStr.Length)
//            {
//                case 1:
//                {
//                    beersMitko += drunkenNumber;
//                    beersVlado += drunkenNumber; break;
//                }
//                case 2:
//                {
//                    beersMitko += (drunkenNumber / 10) % 10;
//                    beersVlado += drunkenNumber % 10; break;
//                }
//                case 3:
//                {
//                    beersMitko += (drunkenNumber/100) % 10 + (drunkenNumber / 10) % 10;
//                    beersVlado += (drunkenNumber / 10) % 10 + drunkenNumber % 10; break;                   
//                }
//                case 4:
//                {
//                    beersMitko += (drunkenNumber / 1000) % 10 + (drunkenNumber / 100) % 10;
//                    beersVlado += (drunkenNumber / 10) % 10 + drunkenNumber % 10; break;
//                }
//                case 5:
//                {
//                    beersMitko += (drunkenNumber / 10000) % 10 + (drunkenNumber / 1000) 
//                                 % 10 + (drunkenNumber / 100) % 10;
//                    beersVlado += (drunkenNumber / 100) % 10 + (drunkenNumber / 10) 
//                                 % 10 + drunkenNumber % 10; break;
//                }
//                case 6:
//                {
//                    beersMitko += (drunkenNumber / 100000) % 10 + (drunkenNumber / 10000) 
//                                 % 10 + (drunkenNumber / 1000) % 10;
//                    beersVlado += (drunkenNumber / 100) % 10 + (drunkenNumber / 10) 
//                                 % 10 + drunkenNumber % 10; break;
//                }
//                case 7:
//                {
//                    beersMitko += (drunkenNumber / 1000000) % 10 + (drunkenNumber / 100000) % 10 
//                                + (drunkenNumber / 10000) % 10 + (drunkenNumber / 1000) % 10;
//                    beersVlado += (drunkenNumber / 1000) % 10 + (drunkenNumber / 100) % 10 
//                                + (drunkenNumber / 10) % 10 + drunkenNumber % 10; break;
//                }
//                case 8:
//                {
//                    beersMitko += (drunkenNumber / 10000000) % 10 + (drunkenNumber / 1000000) % 10 
//                                + (drunkenNumber / 100000) % 10 + (drunkenNumber / 10000) % 10;
//                    beersVlado += (drunkenNumber / 1000) % 10 + (drunkenNumber / 100) % 10 
//                                + (drunkenNumber / 10) % 10 + drunkenNumber % 10; break;
//                }
//                case 9:
//                {
//                    beersMitko += (drunkenNumber / 100000000) % 10 + (drunkenNumber / 10000000) % 10 
//                                + (drunkenNumber / 1000000) % 10 + (drunkenNumber / 100000) % 10 + (drunkenNumber / 10000) % 10;
//                    beersVlado += (drunkenNumber / 10000) % 10 + (drunkenNumber / 1000) % 10 + (drunkenNumber / 100) % 10 
//                                + (drunkenNumber / 10) % 10 + drunkenNumber % 10; break;
//                }                
//            }

//            drunkenStr = "";
//        }

//        if (beersMitko > beersVlado)
//        {
//            Console.WriteLine("M {0}", beersMitko - beersVlado);
//        }
//        else if (beersVlado > beersMitko)
//        {
//            Console.WriteLine("V {0}", beersVlado - beersMitko);
//        }
//        else if (beersMitko == beersVlado)
//        {
//            Console.WriteLine("No {0}", beersMitko + beersVlado);
//        }
//    }
//}