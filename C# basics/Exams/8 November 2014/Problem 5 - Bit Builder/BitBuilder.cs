using System;

class BitBuilder
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string binaryNumber = Convert.ToString(number, 2).PadLeft(32, '0');

        while (true)
        {
            string firstCommand = Console.ReadLine();
            if (firstCommand == "quit")
            {
                break;
            }
            else
            {
                int position = int.Parse(firstCommand);
                int binaryPosition = binaryNumber.Length - 1 - position;
                string command = Console.ReadLine();
             
                if (command == "flip")
                {
                    char[] binaryArr = binaryNumber.ToCharArray();

                    if (binaryArr[binaryPosition] == '1')
                    {
                        binaryArr[binaryPosition] = '0'; 
                    }
                    else
                    {
                        binaryArr[binaryPosition] = '1'; 
                    }

                    binaryNumber = String.Empty;

                    for (int i = 0; i < binaryArr.Length; i++)
                    {
                        binaryNumber += binaryArr[i];
                    }
                }
                else if (command == "remove")
                {
                    binaryNumber = binaryNumber.Remove(binaryPosition, 1);
                }
                else if (command == "insert")
                {
                    binaryNumber = binaryNumber.Insert(binaryPosition + 1, "1");
                }
            }
        }

        long processedNumber = Convert.ToInt64(binaryNumber, 2);
        Console.WriteLine(processedNumber);   
    }
}