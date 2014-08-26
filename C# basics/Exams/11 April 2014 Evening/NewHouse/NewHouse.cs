using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());      
        int firstDashes = n / 2;
        string line = new String ('|', 1);

        for (int i = 1; i <= n/2; i++)
        {
            Console.WriteLine(new String('-', firstDashes) + new String('*', n-(firstDashes+firstDashes)) 
                            + new String('-', firstDashes));
            firstDashes--;
        }

        for (int i = 1; i <= n+1; i++)
        {
            if (i==1)
            {
                Console.WriteLine(new String('*', n));
            }
            else
            {
                Console.WriteLine(line + new String('*', n - 2) + line);
            }                
        }
    }
}