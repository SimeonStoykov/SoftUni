using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string firstNLast =new String (' ', 1)+ new String ('*', n*2-2) + new String (' ', 1);
        string lens = new String('*', 1) + new String('/', n*2-2) + new String('*', 1);
        string bridge = new String(' ', n - 1);
        string middleBridge = new String('-', n - 1);
            
        for (int i = 1; i <= n; i++)
        {               
            if (i==1 || i==n)
            {
                Console.WriteLine(firstNLast + bridge + firstNLast);
            }
            if (i==(n+1)/2)
            {      
                Console.WriteLine(lens + middleBridge + lens);
            }
            if (i > 1 && i < n && i != (n + 1) / 2)
            {
                Console.WriteLine(lens + bridge + lens);
            }
        }
    }
}

