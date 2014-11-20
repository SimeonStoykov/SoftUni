using System;
using System.Collections.Generic;

class Neurons
{
    static void Main()
    {
        List<uint> numbers = new List<uint>();
        uint one = (uint)1;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "-1")
            {
                break;
            }
            uint number = uint.Parse(input);
            uint output = number;

            for (int i = 31; i >= 0; i--)
            {
                uint mask = one << i;
                if ((number & (one << i)) != one << i)
                {
                    number = number | mask;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < 32; i++)
            {
                uint mask = one << i;
                if ((number & (one << i)) != one << i)
                {
                    number = number | mask;
                }
                else
                {
                    break;
                }
            }

            number = ~number;
            numbers.Add(number);
        }

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}

//ALTERNATIVE SOLUTION

//using System;
//using System.Collections.Generic;

//class NeuronMapping2
//{
//    static void Main()
//    {
//        List<uint> input = new List<uint>();
//        while (true)
//        {
//            string inString = Console.ReadLine();
//            if (inString == "-1")
//            {
//                break;
//            }
//            uint number = uint.Parse(inString);
//            number = ~number;
//            for (int i = 0; i < 32; i++)
//            {
//                if ((number & (1 << i)) != 0)
//                {
//                    number = number & (~((uint)1 << i));
//                }
//                else
//                {
//                    break;
//                }
//            }
//            for (int i = 31; i >= 0; i--)
//            {
//                if ((number & (1 << i)) != 0)
//                {
//                    number = number & (~((uint)1 << i));
//                }
//                else
//                {
//                    break;
//                }
//            }
//            input.Add(number);
//        }
//        foreach (var item in input)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}