using System;

class BitPaths
{   
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        string[] rowBits0 = { "0", "0", "0", "0" };
        string[] rowBits1 = { "0", "0", "0", "0" };
        string[] rowBits2 = { "0", "0", "0", "0" };
        string[] rowBits3 = { "0", "0", "0", "0" };
        string[] rowBits4 = { "0", "0", "0", "0" };
        string[] rowBits5 = { "0", "0", "0", "0" };
        string[] rowBits6 = { "0", "0", "0", "0" };
        string[] rowBits7 = { "0", "0", "0", "0" };
        int here = 0;
        
        for (int i = 0; i < lines; i++)
        {
            string[] paths = Console.ReadLine().Split(',');
           
            for (int row = 0; row <= 7; row++)
            {                                         
                if (row == 0)
                {
                    switch (paths[0])
                    {
                        case "0": if (rowBits0[0] == "1") rowBits0[0] = "0";                            
                                  else { rowBits0[0]="1";} here = 0;    break;
                        case "1": if (rowBits0[1] == "1") rowBits0[1] = "0";                            
                                  else { rowBits0[1] = "1"; } here = 1; break;
                        case "2": if (rowBits0[2] == "1") rowBits0[2] = "0";                            
                                  else { rowBits0[2] = "1"; } here = 2; break;
                        case "3": if (rowBits0[3] == "1") rowBits0[3] = "0";                            
                                  else { rowBits0[3] = "1"; } here = 3; break;
                    }
                }
                
                if (row == 1)
                {                   
                    switch (paths[1])
                    {
                        case "+1": if (rowBits1[here + 1] == "0") rowBits1[here + 1] = "1";
                                   else rowBits1[here + 1] = "0"; here = here + 1; break;
                        case "-1": if (rowBits1[here - 1] == "0") rowBits1[here - 1] = "1";
                                   else rowBits1[here - 1] = "0"; here = here - 1; break;                                                           
                        case "0":  if (rowBits1[here] == "0") rowBits1[here] = "1";
                                   else rowBits1[here] = "0"; break;
                    }                    
                }
               
                if (row == 2)
                {                   
                    switch (paths[2])
                    {
                        case "+1": if (rowBits2[here + 1] == "0") rowBits2[here + 1] = "1";
                                   else rowBits2[here + 1] = "0"; here = here + 1; break;
                        case "-1": if (rowBits2[here - 1] == "0") rowBits2[here - 1] = "1";
                                   else rowBits2[here - 1] = "0"; here = here - 1; break;                                                            
                        case "0":  if (rowBits2[here] == "0") rowBits2[here] = "1";
                                   else rowBits2[here] = "0"; break;
                    }                   
                }
                
                if (row == 3)
                {                    
                    switch (paths[3])
                    {
                        case "+1": if (rowBits3[here + 1] == "0") rowBits3[here + 1] = "1";
                                   else rowBits3[here + 1] = "0"; here = here + 1; break;
                        case "-1": if (rowBits3[here - 1] == "0") rowBits3[here - 1] = "1";
                                   else rowBits3[here - 1] = "0"; here = here - 1; break;                                                                                    
                        case "0":  if (rowBits3[here] == "0") rowBits3[here] = "1";
                                   else rowBits3[here] = "0"; break;
                    }                    
                }
               
                if (row == 4)
                {                   
                    switch (paths[4])
                    {
                        case "+1": if (rowBits4[here + 1] == "0") rowBits4[here + 1] = "1";
                                   else rowBits4[here + 1] = "0"; here = here + 1; break;
                        case "-1": if (rowBits4[here - 1] == "0") rowBits4[here - 1] = "1";
                                   else rowBits4[here - 1] = "0"; here = here - 1; break;                                                            
                        case "0":  if (rowBits4[here] == "0") rowBits4[here] = "1";
                                   else rowBits4[here] = "0"; break;
                    }                    
                }
                
                if (row == 5)
                {                    
                    switch (paths[5])
                    {
                        case "+1": if (rowBits5[here + 1] == "0") rowBits5[here + 1] = "1";
                                   else rowBits5[here + 1] = "0"; here = here + 1; break;
                        case "-1": if (rowBits5[here - 1] == "0") rowBits5[here - 1] = "1";
                                   else rowBits5[here - 1] = "0"; here = here - 1; break;                                                            
                        case "0":  if (rowBits5[here] == "0") rowBits5[here] = "1";
                                   else rowBits5[here] = "0"; break;
                    }                   
                }
                
                if (row == 6)
                {                   
                    switch (paths[6])
                    {
                        case "+1": if (rowBits6[here + 1] == "0") rowBits6[here + 1] = "1";
                                   else rowBits6[here + 1] = "0"; here = here + 1; break;
                        case "-1": if (rowBits6[here - 1] == "0") rowBits6[here - 1] = "1";
                                   else rowBits6[here - 1] = "0"; here = here - 1; break;                                                           
                        case "0":  if (rowBits6[here] == "0") rowBits6[here] = "1";
                                   else rowBits6[here] = "0"; break;
                    }                    
                }
               
                if (row == 7)
                {                   
                    switch (paths[7])
                    {
                        case "+1": if (rowBits7[here + 1] == "0") rowBits7[here + 1] = "1";
                                   else rowBits7[here + 1] = "0"; here = here + 1; break;
                        case "-1": if (rowBits7[here - 1] == "0") rowBits7[here - 1] = "1";
                                   else rowBits7[here - 1] = "0"; here = here - 1; break;                                                            
                        case "0":  if (rowBits7[here] == "0") rowBits7[here] = "1";
                                   else rowBits7[here] = "0"; break;
                    }                    
                }                
            }
        }

        string number0 = "";       
        foreach (var item in rowBits0)
        {
            number0 = number0 + item;           
        }       
        int zeroNumber = Convert.ToInt32(number0, 2);

        string number1 = ""; 
        foreach (var item in rowBits1)
        {
            number1 = number1 + item;   
        }
        int firstNumber = Convert.ToInt32(number1, 2);

        string number2 = ""; 
        foreach (var item in rowBits2)
        {
            number2 = number2 + item; 
        }
        int secondNumber = Convert.ToInt32(number2, 2);

        string number3 = ""; 
        foreach (var item in rowBits3)
        {
            number3 = number3 + item; 
        }
        int thirdNumber = Convert.ToInt32(number3, 2);

        string number4 = "";
        foreach (var item in rowBits4)
        {
            number4 = number4 + item;
        }
        int fourthNumber = Convert.ToInt32(number4, 2);

        string number5 = "";
        foreach (var item in rowBits5)
        {
            number5 = number5 + item;
        }
        int fifthNumber = Convert.ToInt32(number5, 2);

        string number6 = "";
        foreach (var item in rowBits6)
        {
            number6 = number6 + item;
        }
        int sixthNumber = Convert.ToInt32(number6, 2);

        string number7 = "";
        foreach (var item in rowBits7)
        {
            number7 = number7 + item;
        }
        int seventhNumber = Convert.ToInt32(number7, 2);

        int sum = zeroNumber + firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber + sixthNumber 
                + seventhNumber;
        string binarySum = Convert.ToString(sum,2);
        Console.WriteLine("{0}\n{1:X}", binarySum, sum);
    }
}