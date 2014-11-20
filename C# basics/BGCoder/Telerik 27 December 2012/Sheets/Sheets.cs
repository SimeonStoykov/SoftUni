using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Sheets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a0 = 1024, a1 = 512, a2 = 256, a3 = 128, a4 = 64, a5 = 32,
            a6 = 16, a7 = 8, a8 = 4, a9 = 2, a10 = 1;
        List<int> arr = new List<int>() { a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 };
        for (int i = 0; i < arr.Count; i++)
        {
            if (n < arr[i])
            {
                Console.WriteLine("A{0}", i);
            }
            else if (n >= arr[i])
            {
                n = n - arr[i];
            }
        }
    }
}

//ALTERNATIVE SOLUTION

//using System;
 
//class Sheets
//{
//    static void Main()
//    {
//        String binary = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(11, '0');
//        for (int index = 0; index <= 10; index++) if (binary[index] == '0') 
//        {
//        Console.WriteLine("A{0}", index);
//        }
//    }
//}
