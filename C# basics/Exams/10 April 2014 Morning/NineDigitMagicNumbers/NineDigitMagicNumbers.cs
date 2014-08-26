using System;
using System.Text.RegularExpressions;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isOk = false;

        int a;
        int b;
        int c;       
        string num;

        for (int i = 111; i <= 777; i++)
        {
            int tempSum = 0;
            a = i;
            b = a + diff;
            c = b + diff;

            num = a.ToString() + b + c;
            Regex r = new Regex("0|8|9");
            if (!r.IsMatch(num))
            {
                for (int j = 0; j <num.Length; j++)
                {
                    tempSum += int.Parse(num[j].ToString());
                }

                if (tempSum==sum && num.Length==9)
                {
                    Console.WriteLine(num);
                    isOk = true;
                }
            }
        }

        if (isOk==false)Console.WriteLine("No");          
    }
}

