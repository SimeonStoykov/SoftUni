using System;

class XExpression
{
    static void Main()
    {
        int symbol = Console.Read();
        decimal sum = 0;
        int o = '+';

        while (symbol != '=')
        {
            if (symbol == '(')
            {
                symbol = Console.Read();
                decimal innerSum = 0;
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
                            case '/': innerSum /= symbol - '0'; break;
                        }
                    }
                    else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
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
                    case '/': sum /= innerSum; break;
                }
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                switch (o)
                {
                    case '+': sum += symbol - '0'; break;
                    case '-': sum -= symbol - '0'; break;
                    case '*': sum *= symbol - '0'; break;
                    case '/': sum /= symbol - '0'; break;
                }
            }
            else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
            {
                o = symbol;
            }
            symbol = Console.Read();
        }

        Console.WriteLine("{0:f2}", sum);
    }
}

//ALTERNATIVE SOLUTION - WORKING FOR NUMBERS(NOT ONLY FOR DIGITS)

//using System;
//using System.Text;

//class XExpression
//{
//    static void Main()
//    {
//        bool insideBrackets = false;
//        char operation = '+';
//        char operationBeforeBrackets = '+';
//        decimal number;
//        decimal result = 0;
//        decimal resultBeforeBrackets = 0;
//        decimal resultInsideBrackets = 0;
//        StringBuilder numberString = new StringBuilder();
//        numberString.Append('0');
//        string expression = Console.ReadLine();
//        for (int i = 0; i < expression.Length; i++)
//        {
//            if ((expression[i] >= '0' && expression[i] <= '9') || expression[i] == '.') // digit
//            {
//                numberString.Append(expression[i]);
//            }
//            else if (expression[i] == '(')
//            {
//                insideBrackets = true;
//                resultBeforeBrackets = result;
//                resultInsideBrackets = 0;
//                operationBeforeBrackets = operation;
//                operation = '+';
//            }
//            else
//            {
//                number = decimal.Parse(numberString.ToString());
//                numberString.Clear();
//                numberString.Append('0');
//                if (!insideBrackets)
//                {
//                    switch (operation)
//                    {
//                        case '+':
//                            result += number;
//                            break;
//                        case '-':
//                            result -= number;
//                            break;
//                        case '*':
//                            result *= number;
//                            break;
//                        case '/':
//                            result /= number;
//                            break;
//                    }
//                }
//                else //  inside Brackets
//                {
//                    switch (operation)
//                    {
//                        case '+':
//                            resultInsideBrackets += number;
//                            break;
//                        case '-':
//                            resultInsideBrackets -= number;
//                            break;
//                        case '*':
//                            resultInsideBrackets *= number;
//                            break;
//                        case '/':
//                            resultInsideBrackets /= number;
//                            break;
//                        case ')':
//                            switch (operationBeforeBrackets)
//                            {
//                                case '+':
//                                    result = resultBeforeBrackets + resultInsideBrackets;
//                                    break;
//                                case '-':
//                                    result = resultBeforeBrackets - resultInsideBrackets;
//                                    break;
//                                case '*':
//                                    result = resultBeforeBrackets * resultInsideBrackets;
//                                    break;
//                                case '/':
//                                    result = resultBeforeBrackets / resultInsideBrackets;
//                                    break;
//                            }
//                            insideBrackets = false;
//                            break;
//                    }
//                }
//                operation = expression[i];
//            }
//        }
//        Console.WriteLine("{0:F2}", result);
//    }
//}