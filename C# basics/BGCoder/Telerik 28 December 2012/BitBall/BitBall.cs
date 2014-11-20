using System;

class BitBall
{
    static void Main()
    {
        byte[] topPlayers = new byte[8];
        byte[] bottomPlayers = new byte[8];
      
        string[] binaryTop = new string[8];
        string[] binaryBot = new string[8];
        char[,] united = new char[8, 8];
        int topGoals = 0;
        int botGoals = 0;
      
        for (int i = 0; i < topPlayers.Length; i++)
        {
            topPlayers[i] = byte.Parse(Console.ReadLine());
        }
        for (int i = 0; i < bottomPlayers.Length; i++)
        {
            bottomPlayers[i] = byte.Parse(Console.ReadLine());
        }

        for (int i = 0; i < topPlayers.Length; i++)
        {
            binaryTop[i] = Convert.ToString(topPlayers[i], 2).PadLeft(8, '0');
        }
        for (int i = 0; i < bottomPlayers.Length; i++)
        {
            binaryBot[i] = Convert.ToString(bottomPlayers[i], 2).PadLeft(8, '0');
        }

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if ((binaryTop[row][col] == '0' && binaryBot[row][col] == '0') 
                 || (binaryTop[row][col] == '1' && binaryBot[row][col] == '1'))
                {
                    united[row, col] = '0';
                }
                if (binaryTop [row][col] == '1' && binaryBot [row][col] == '0')
                {
                    united[row, col] = '1';
                }
                if (binaryTop[row][col] == '0' && binaryBot[row][col] == '1')
                {
                    united[row, col] = '2';
                }
            }
        }

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                bool isRowFreeTop = true;
                bool isRowFreeBot = true;

                if (united[row, col] == '1')
                {                    
                    for (int i = row + 1; i < 8; i++)
                    {
                        if (united[i, col] != '0')
                        {
                            isRowFreeTop = false;
                        }
                    }

                    if (isRowFreeTop)
                    {
                        topGoals++;
                    }
                    
                }

                if (united[row, col] == '2')
                {
                    for (int i = row - 1; i >= 0; i--)
                    {                      
			            if (united[i, col] != '0')
                        {
                            isRowFreeBot = false;
                        }
		            }

                    if (isRowFreeBot)
                    {
                        botGoals++;
                    }                        
                }                   
             }               
         }
        
        Console.WriteLine("{0}:{1}", topGoals, botGoals);                              
    }
}