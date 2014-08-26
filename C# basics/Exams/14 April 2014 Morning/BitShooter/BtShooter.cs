using System;

class BitShooter
{
    static void Main()
    {
        const int BITS = 64;

        ulong number = ulong.Parse(Console.ReadLine());              
        ulong shootBits = 0;

        for (int i = 0; i < 3; i++)
        {            
            string shoot = Console.ReadLine();
            string[] shootDetails = shoot.Split(' ');
            int shootCenter = int.Parse(shootDetails[0]);
            int shootSize = int.Parse(shootDetails[1]);
          
            int startBit = shootCenter - shootSize / 2;
            int endBit = shootCenter + shootSize / 2;
          
            for (int bit = startBit; bit <= endBit; bit++)
            {
                if (bit >= 0 && bit < BITS)
                {
                    shootBits = shootBits | ((ulong)1 << bit);                    
                }
            }
        }
        
        ulong aliveBits = number & (~shootBits);
        
        ulong rightBits = 0;
        for (int i = 0; i < BITS / 2; i++)
        {
            rightBits += aliveBits & 1;
            aliveBits = aliveBits >> 1;
        }

        ulong leftBits = 0;
        for (int i = 0; i < BITS / 2; i++)
        {
            leftBits += aliveBits & 1;
            aliveBits >>= 1;
        }
        
        Console.WriteLine("left: " + leftBits);
        Console.WriteLine("right: " + rightBits);
    }
}