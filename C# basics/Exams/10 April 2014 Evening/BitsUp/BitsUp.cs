using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;

        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int bits = 7; bits >= 0; bits--)
            {
                if ((step == 1 && index > 0) || index % step == 1)
                {
                    number = number | 1 << bits;
                }
                index++;
            }
            Console.WriteLine(number);
        }
    }
}

//ALTERNATIVE SOLUTION (with strings)

//    int n=int.Parse(Console.ReadLine());
//    int step = int.Parse(Console.ReadLine());

//    string wholeSequence = "";  

//    for (int i = 0; i < n; i++)             
//    {
//        int number=int.Parse(Console.ReadLine());    
//        string currSequence = "";                       
//        for (int k = 0; k < 8; k++)                     
//        {
//            int lastDigit = (number & (1<<k)) >> k;        
//            currSequence=lastDigit+currSequence;           
//        }                                                    
//        wholeSequence=wholeSequence+currSequence;         
//    }

//    char[] digits = wholeSequence.ToCharArray();       
            
//    for (int i = 0; i < digits.Length; i++)            
//    {
//        int position = 1+i*step;                       
//        if (position>digits.Length-1)               
//            {
//                break;
//            }
//        digits[position]='1';                                         
//    }

//    string currNumber="";                          

//    for (int i = 0; i < digits.Length; i++)       
//    {
//        currNumber+=digits[i];
//        if ((i+1)%8==0)                           
//            {
//                int result = Convert.ToInt32(currNumber,2);  
//                Console.WriteLine(result);                   
//                currNumber="";                               
//            }
//    }

