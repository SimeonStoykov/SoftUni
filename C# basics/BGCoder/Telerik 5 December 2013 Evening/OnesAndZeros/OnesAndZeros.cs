using System;

class OnesAndZeros
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        string binaryNumber = Convert.ToString(number, 2).PadLeft(32, '0');
        binaryNumber = binaryNumber.Remove(0, 16);

        for (int row = 1; row <= 5; row++)
        {
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (i == binaryNumber.Length - 1)
                {
                    if (binaryNumber[i] == '0')
                    {
                        switch (row)
                        {
                            case 1: Console.Write("###"); break;
                            case 2: Console.Write("#.#"); break;
                            case 3: Console.Write("#.#"); break;
                            case 4: Console.Write("#.#"); break;
                            case 5: Console.Write("###"); break;
                        }
                                              
                    }
                    else if (binaryNumber[i] == '1')
                    {
                        switch (row)
                        {
                            case 1: Console.Write(".#."); break;
                            case 2: Console.Write("##."); break;
                            case 3: Console.Write(".#."); break;
                            case 4: Console.Write(".#."); break;
                            case 5: Console.Write("###"); break;
                        }         
                    }
                }
                else
                {
                    if (binaryNumber[i] == '0')
                    {
                        switch (row)
                        {
                            case 1: Console.Write("###."); break;
                            case 2: Console.Write("#.#."); break;
                            case 3: Console.Write("#.#."); break;
                            case 4: Console.Write("#.#."); break;
                            case 5: Console.Write("###."); break;
                        }                         
                    }
                    else if (binaryNumber[i] == '1')
                    {
                        switch (row)
                        {
                            case 1: Console.Write(".#.."); break;
                            case 2: Console.Write("##.."); break;
                            case 3: Console.Write(".#.."); break;
                            case 4: Console.Write(".#.."); break;
                            case 5: Console.Write("###."); break;
                        }                        
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

//ALTERNATIVE SOLUTION

//using System;
//using System.Linq;
//using System.Text;

//class OnesAndZeros
//{
//    static string[] zero = new string[] { "###", "#.#", "#.#", "#.#", "###" };
//    static string[] one = new string[] { ".#.", "##.", ".#.", ".#.", "###" };
//    static int numberOfBits = 16;

//    static void Main()
//    {
//        var binary = Convert.ToString(int.Parse(Console.ReadLine()), 2);
//        binary = binary.Length < 16 ? binary.PadLeft(numberOfBits, '0') 
//               : binary.Substring(binary.Length - numberOfBits);

//        var result = new StringBuilder();

//        for (int i = 0; i < zero.Length; i++)
//        {
//            for (int j = 0; j < binary.Length; j++)
//            {
//                result.Append((binary[j] == '0' ? zero[i] : one[i]) + ".");
//            }

//            result.Length--;
//            result.AppendLine();
//        }
//        Console.Write(result);
//    }
//}