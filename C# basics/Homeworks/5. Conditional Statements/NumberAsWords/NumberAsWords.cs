using System;

class NumberAsWords
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 0: Console.WriteLine("zero"); break;
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;
            case 10: Console.WriteLine("ten"); break;
            case 11: Console.WriteLine("eleven"); break;
            case 12: Console.WriteLine("twelve"); break;
            case 13: Console.WriteLine("thirteen"); break;
            case 14: Console.WriteLine("forteen"); break;
            case 15: Console.WriteLine("fifteen"); break;
            case 16: Console.WriteLine("sixteen"); break;
            case 17: Console.WriteLine("seventeen"); break;
            case 18: Console.WriteLine("eighteen"); break;
            case 19: Console.WriteLine("nineteen"); break;
            case 20: Console.WriteLine("twenty"); break;                                                     
        }
        if (number/100==9)
        {
            Console.Write("Nine hundred ");
        }
        if (number/100==8)
        {
            Console.Write("Eight hundred ");
        }
            if (number / 100 == 7)
        {
            Console.Write("Seven hundred ");
        }
        if (number / 100 == 6)
        {
            Console.Write("Six hundred ");
        }
        if (number / 100 == 5)
        {
            Console.Write("Five hundred ");
        }
        if (number / 100 == 4)
        {
            Console.Write("Four hundred ");
        }
        if (number / 100 == 3)
        {
            Console.Write("Three hundred ");
        }
        if (number / 100 == 2)
        {
            Console.Write("Two hundred ");  
        }
        if (number / 100 == 1)
        {
            Console.Write("One hundred ");
        }

        if (number == 100 || number == 200 || number == 300 || number == 400 || number == 500 || number == 600 
            || number == 700 || number == 800 || number == 900)
        {
            Console.WriteLine();
        }

        if ((number % 100) / 10 == 0 && number != 100 && number != 200 && number != 300 && number != 400 && number != 500 
            && number != 600 && number != 700 && number != 800 && number != 900)
        {
            Console.Write("and ");
        }
             
        if ((number%100)/10==2)
        {
            if (number<100)
            {
                Console.Write("Twenty ");
            }
            else
            {
                if (number%10==0)
                {
                    Console.WriteLine("and twenty ");
                }
                else
                {
                    Console.Write("and twenty ");
                }                   
            }                                
        }

        if ((number % 100) / 10 == 3)
        {
            if (number < 100)
            {
                Console.Write("Thirty ");
            }
            else
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine("and thirty ");
                }
                else
                {
                    Console.Write("and thirty ");
                }
            }
        }

        if ((number % 100) / 10 == 4)
        {
            if (number < 100)
            {
                Console.Write("Fourty ");
            }
            else
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine("and fourty ");
                }
                else
                {
                    Console.Write("and fourty ");
                }
            }
        }

        if ((number % 100) / 10 == 5)
        {
            if (number < 100)
            {
                Console.Write("Fifty ");
            }
            else
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine("and fifty ");
                }
                else
                {
                    Console.Write("and fifty ");
                }
            }
        }

        if ((number % 100) / 10 == 6)
        {
            if (number < 100)
            {
                Console.Write("Sixty ");
            }
            else
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine("and sixty ");
                }
                else
                {
                    Console.Write("and sixty ");
                }
            }
        }

        if ((number % 100) / 10 == 7)
        {
            if (number < 100)
            {
                Console.Write("Seventy ");
            }
            else
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine("and seventy ");
                }
                else
                {
                    Console.Write("and seventy ");
                }
            }
        }

        if ((number % 100) / 10 == 8)
        {
            if (number < 100)
            {
                Console.Write("Eighty ");
            }
            else
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine("and eighty ");
                }
                else
                {
                    Console.Write("and eighty ");
                }
            }
        }

        if ((number % 100) / 10 == 9)
        {
            if (number < 100)
            {
                Console.Write("Ninety ");
            }
            else
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine("and ninety ");
                }
                else
                {
                    Console.Write("and ninety ");
                }
            }
        }

        if (number % 10 == 1 && (number % 100) / 10 != 1 && number>10)
        {
            Console.WriteLine("one");
        }
        if (number % 10 == 2 && (number % 100) / 10 != 1 && number > 10)
        {
            Console.WriteLine("two");
        }
        if (number % 10 == 3 && (number % 100) / 10 != 1 && number > 10)
        {
            Console.WriteLine("three");
        }
        if (number % 10 == 4 && (number % 100) / 10 != 1 && number > 10)
        {
            Console.WriteLine("four");
        }
        if (number % 10 == 5 && (number % 100) / 10 != 1 && number > 10)
        {
            Console.WriteLine("five");
        }
        if (number % 10 == 6 && (number % 100) / 10 != 1 && number > 10)
        {
            Console.WriteLine("six");
        }
        if (number % 10 == 7 && (number % 100) / 10 != 1 && number > 10)
        {
            Console.WriteLine("seven");
        }
        if (number % 10 == 8 && (number % 100) / 10 != 1 && number > 10)
        {
            Console.WriteLine("eight");
        }
        if (number % 10 == 9 && (number % 100) / 10 != 1 && number > 10)
        {
            Console.WriteLine("nine");
        }

        if ((number % 100) / 10 == 1 && number % 10 == 0 && number > 100)
        {
            Console.WriteLine("and ten ");
        }
        if ((number % 100) / 10 == 1 && number % 10 == 1 && number > 100)
        {
            Console.WriteLine("and eleven");
        }
        if ((number % 100) / 10 == 1 && number % 10 == 2 && number>100)
        {
            Console.WriteLine("and twelve ");
        }
        if ((number % 100) / 10 == 1 && number % 10 == 3 && number > 100)
        {
            Console.WriteLine("and thirthteen ");
        }
        if ((number % 100) / 10 == 1 && number % 10 == 4 && number > 100)
        {
            Console.WriteLine("and forteen ");
        }
        if ((number % 100) / 10 == 1 && number % 10 == 5 && number > 100)
        {
            Console.WriteLine("and fifteen ");
        }
        if ((number % 100) / 10 == 1 && number % 10 == 6 && number > 100)
        {
            Console.WriteLine("and sixteen ");
        }
        if ((number % 100) / 10 == 1 && number % 10 == 7 && number > 100)
        {
            Console.WriteLine("and seventeen ");
        }
        if ((number % 100) / 10 == 1 && number % 10 == 8 && number > 100)
        {
            Console.WriteLine("and eighteen ");
        }
        if ((number % 100) / 10 == 1 && number % 10 == 9 && number > 100)
        {
            Console.WriteLine("and nineteen ");
        }                                              
    }
}

