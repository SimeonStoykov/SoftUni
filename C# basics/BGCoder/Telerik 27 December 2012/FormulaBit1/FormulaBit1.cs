using System;

class FormulaBit1
{
    static void Main()
    {
        byte[] numbers = new byte[8];
        string [] binary = new string [8];
        string direction = "south";
        string prevDirection = String.Empty;
        int trackLength = 0;
        int turns = 0;
        
        int row = 0;
        int col = 7;
        bool finished = true;
       
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = byte.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            binary[i] = Convert.ToString(numbers[i], 2).PadLeft(8, '0');
        }
        
        while (true)
        {
            if (direction == "south")
            {
                if (row == 7 && col == 0 && binary[row][col] == '0')
                {
                    trackLength++;
                    break;
                }

                if (binary[row][col] == '0' && row + 1 <= 7)
                {
                    trackLength++;
                    row++;
                    continue;
                }

                if (binary[row][col] == '0' && row + 1 > 7)
                {
                    trackLength++;                   
                    col--;
                    if (col >= 0)
                    {
                        if (binary[row][col] == '0')
                        {
                            prevDirection = "south";
                            direction = "west";
                            turns++;
                        }
                        else
                        {
                            finished = false;
                            break;
                        }
                    }
                    else
                    {
                        finished = false;
                        break;
                    }
                }                              
               
                if (binary[row][col] == '1')
                {
                    row--;
                    col--;
                    if (col >= 0 && row >= 0)
                    {
                        if (binary[row][col] == '1')
                        {
                            finished = false;
                            break;
                        }
                        else if (binary[row][col] == '0')
                        {
                            prevDirection = "south";
                            direction = "west";
                            turns++;
                        }
                    }
                    else
                    {
                        finished = false;
                        break;
                    }
                }
            }
            
           
            if (direction == "west")            
            {
                if (row == 7 && col == 0 && binary[row][col] == '0')
                {
                    trackLength++;
                    break;
                }

                if (binary[row][col] == '0' && col - 1 >= 0)
                {
                    trackLength++;
                    col--;
                    continue;
                }

                if (binary[row][col] == '0' && col - 1 < 0 && prevDirection == "south")
                {
                    trackLength++;
                    row--;
                    if (row >= 0)
                    {
                        if (binary[row][col] == '0')
                        {
                            direction = "north";
                            turns++;
                        }
                        else
                        {
                            finished = false;
                            break;
                        }
                    }
                    else
                    {
                        finished = false;
                        break;
                    }                   
                }
                if (binary[row][col] == '0' && col - 1 < 0 && prevDirection == "north")
                {
                    trackLength++;
                    row++;
                    if (row <= 7)
                    {
                        if (binary[row][col] == '0')
                        {
                            direction = "south";
                            turns++;
                        }
                        else
                        {
                            finished = false;
                            break;
                        }
                    }
                    else
                    {
                        finished = false;
                        break;
                    }
                }

                if (binary[row][col] == '1' && prevDirection == "south")
                {
                    row--;
                    col++;
                    if (col <= 7 && row >= 0)
                    {
                        if (binary[row][col] == '1')
                        {
                            finished = false;
                            break;
                        }
                        else if (binary[row][col] == '0')
                        {
                            direction = "north";
                            turns++;
                        }
                    }
                    else
                    {
                        finished = false;
                        break;
                    }
                }

                if (binary[row][col] == '1' && prevDirection == "north")
                {
                    row++;
                    col++;
                    if (col <= 7 && row <= 7)
                    {
                        if (binary[row][col] == '1')
                        {
                            finished = false;
                            break;
                        }
                        else if (binary[row][col] == '0')
                        {
                            direction = "south";
                            turns++;
                        }
                    }
                    else
                    {
                        finished = false;
                        break;
                    }
                }
            }

            if (direction == "north")
            {              
                if (binary[row][col] == '0' && row - 1 >= 0)
                {
                    trackLength++;
                    row--;
                    continue;
                }
                if (binary[row][col] == '0' && row - 1 < 0)
                {
                    trackLength++;
                    col--;
                    if (col >= 0)
                    {
                        if (binary[row][col] == '0')
                        {
                            prevDirection = "north";
                            direction = "west";
                            turns++;
                        }
                        else
                        {
                            finished = false;
                            break;
                        }
                    }
                    else
                    {                        
                        finished = false;
                        break;                       
                    }
                }

                if (binary[row][col] == '1')
                {
                    row++;
                    col--;
                    if (col >= 0 && row <= 7)
                    {
                        if (binary[row][col] == '1')
                        {
                            finished = false;
                            break;
                        }
                        else if (binary[row][col] == '0')
                        {
                            prevDirection = "north";
                            direction = "west";
                            turns++;
                        }
                    }
                    else
                    {
                        finished = false;
                        break;
                    }
                }
            }           
        }
       
        if (finished == false)
        {
            Console.WriteLine("No " + trackLength);
        }
        else
        {            
            Console.WriteLine(trackLength + " " + turns);
        }                    
    }
}