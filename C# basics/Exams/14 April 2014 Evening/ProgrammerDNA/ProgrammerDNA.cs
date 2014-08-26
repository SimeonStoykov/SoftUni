using System;

class ProgrammerDNA
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int dotsCount = 0;
        char firstLetter = char.Parse(Console.ReadLine());

        for (int row = 0; row < length; row++)
        {
            if (row % 7 == 0 || row % 7 == 6)
            {
                dotsCount = 3;
            }
            else if (row % 7 == 1 || row % 7 == 5)
            {
                dotsCount = 2;
            }
            else if (row % 7 == 2 || row % 7 == 4)
            {
                dotsCount = 1;
            }
            else if (row % 7 == 3)
            {
                dotsCount = 0;
            }

            Console.Write(new String('.', dotsCount));

            for (int i = 0; i < 7 - (2 * dotsCount); i++)
            {
                Console.Write(firstLetter);
                firstLetter = (char)(firstLetter + 1);

                if (firstLetter == 'H')
                {
                    firstLetter = 'A';
                }
            }

            Console.WriteLine(new String('.', dotsCount));
        }
    }
}
