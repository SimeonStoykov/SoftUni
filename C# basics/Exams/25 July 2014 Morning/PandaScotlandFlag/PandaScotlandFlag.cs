using System;

class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int diezCount = n - 2;
        int waveCount = 0;
        int newWaveCount = 0;
        char[] letters = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
                          'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        int counter = 0;

        for (int i = 0; i < n; i++)
          {                                               
            if (i < n / 2)     //before middle
            {
                if (counter==26)
                {
                    counter = 0;
                }
                Console.Write(new String('~', waveCount) + new String(letters[counter], 1) + new String('#', diezCount));
                counter++;
                if (counter == 26)
                {
                    counter = 0;
                }
                Console.WriteLine(new String(letters[counter], 1) + new String('~', waveCount));
                diezCount -= 2;
                waveCount++;
                counter++;                    
            }

            if (i == (n / 2) - 2)
            {
                newWaveCount = waveCount;
            }

            if (i == n / 2) //middle line
            {
                if (counter == 26)
                {
                    counter = 0;
                }
                Console.WriteLine(new String('-', n / 2) + new String(letters[counter], 1) + new String('-', n / 2));
                counter++;
                if (counter == 26)
                {
                    counter = 0;
                }                 
            }

            if (i == n / 2 + 1)   
            {
                diezCount = 1;
                waveCount = newWaveCount;
            }

            if (i > n / 2 && i < n) //after middle
            {
                Console.Write(new String('~', waveCount) + new String(letters[counter], 1) + new String('#', diezCount));                    
                counter++;
                if (counter == 26)
                {
                    counter = 0;
                }
                Console.WriteLine(new String(letters[counter], 1) + new String('~', waveCount));
                diezCount += 2;
                waveCount--;
                counter++;                   
            }
         }                          
    }
}