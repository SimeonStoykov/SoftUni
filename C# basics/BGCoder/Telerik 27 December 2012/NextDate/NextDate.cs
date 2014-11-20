using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int nextDay = day + 1;
        int nextMonth = month;
        int nextYear = year;

        if ((month == 1 || month == 3 || month == 5 || month == 7 
          || month == 8 || month == 10 || month == 12) && day == 31)
        {
            nextDay = 1;
            if (month != 12)
            {
                nextMonth = month + 1;
            }
            else
            {
                nextMonth = 1;
                nextYear = year + 1;
            }            
        }

        if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 30)
        {
            nextDay = 1;
            nextMonth = month + 1;
        }

        if (month == 2 && day == 28 && year != 2000 && year != 2004 
         && year != 2008 && year != 2012)
        {
            nextDay = 1;
            nextMonth = 3;
        }
        else if (month == 2 && day == 29 && (year == 2000 || year == 2004 
              || year == 2008 || year == 2012))
        {
            nextDay = 1;
            nextMonth = 3;
        }

        Console.WriteLine("{0}.{1}.{2}", nextDay, nextMonth, nextYear);
    }
}