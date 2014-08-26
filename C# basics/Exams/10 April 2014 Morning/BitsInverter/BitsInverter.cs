using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int bits = 7; bits >= 0; bits--)
            {
                if (index == 0 || (index % step == 0))
                {
                    number = number ^ (1 << bits);
                }

                index++;
            }
            Console.WriteLine(number);
        }
    }
}

//ALTERNATIVE SOLUTION (with strings)

//using System;
//using System.Linq;

//class BitsInverter
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        int step = int.Parse(Console.ReadLine());
//        string num = "";

//        for (int i = 0; i < n; i++)
//        {
//            int number = int.Parse(Console.ReadLine());
//            num += Convert.ToString(number, 2).PadLeft(8, '0'); //Turning the numbers to string (each number have 8 bits)
//        }

//        char[] digits = num.ToCharArray(); //Creatings array of bits

          //Loop going thru position 0 and every position at the step, changing the bits at those positions
//        for (int i = 0; i < digits.Length; i+=step) 
//        {
//            if (digits[i]=='1')
//            {
//                digits[i] = '0';
//            }
//            else
//            {
//                digits[i] = '1';
//            }
//        }

//        num = new String(digits); //Creating new string of bits (we get them from the array)

//        for (int i = 0; i < num.Length; i+=8) //Go thru the string with step 8 (the bits for 1 number)
//        {
              //Printing the converted in Int 8 bits of each number
//            Console.WriteLine(Convert.ToInt32(num.Substring(i, 8), 2)); 
//        }
//    }
//}

