using System;

class WeAllLoveBits
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());

       for (int i = 0; i < n; i++)
       {
           int num = int.Parse(Console.ReadLine());
           int result = 0;
           while (num > 0)
           {
               int lastBit = num & 1;  //Reversing position of bits (111000 -> 000111)
               num = num >> 1;
               result = result << 1;
               result = result | lastBit;
           }

           Console.WriteLine(result);
       }      
   }
}

//Invert all bits (0-->1, 1-->0)

//int n = 9;
//Console.WriteLine(n);
//string num = Convert.ToString(n, 2);            
//Console.WriteLine(num);
//char[] digits = num.ToCharArray();

//string newStr = "";

//for (int i = 0; i < digits.Length; i++)
//{
//    if (digits[i]=='1')
//    {
//        digits[i] = '0';
//    }
//    else
//    {
//        digits[i] = '1';
//    }
//    newStr += digits[i];
//}

//Console.WriteLine(Convert.ToInt32(newStr,2));
//Console.WriteLine(newStr);
