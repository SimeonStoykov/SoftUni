using System;

class Enigmanation
{
    static void Main()
    {
        int symbol = Console.Read();
        double sum = 0;
        int o = '+';

        while (symbol != '=')
        {
            if (symbol == '(')
            {
                double innerSum = 0;
                int innerO = '+';

                while (symbol != ')')
                {
                    if (symbol >= '0' && symbol <= '9')
                    {
                        switch (innerO)
                        {
                            case '+': innerSum += symbol - '0'; break;
                            case '-': innerSum -= symbol - '0'; break;
                            case '*': innerSum *= symbol - '0'; break;
                            case '%': innerSum %= symbol - '0'; break;
                        }
                    }
                    else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '%')
                    {
                        innerO = symbol;
                    }

                    symbol = Console.Read();
                }

                switch (o)
                {
                    case '+': sum += innerSum; break;
                    case '-': sum -= innerSum; break;
                    case '*': sum *= innerSum; break;
                    case '%': sum %= innerSum; break;
                }
                
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                switch (o)
                {
                    case '+': sum += symbol - '0'; break;
                    case '-': sum -= symbol - '0'; break;
                    case '*': sum *= symbol - '0'; break;
                    case '%': sum %= symbol - '0'; break;                    
                }
                
            }
            else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '%')
            {
                o = symbol;
            }

            symbol = Console.Read();
        }

        Console.WriteLine("{0:f3}", sum);
    }
}