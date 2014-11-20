using System;

class Budget
{
    static void Main()
    {
        int amountOfMoneyAvailable = int.Parse(Console.ReadLine());
        int weekDaysOut = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());

        int normalWeekends = 4 - hometownWeekends;
        int normalWeekendDaysExpenses = normalWeekends * 2 * 20;
        int goingOutExpenses = weekDaysOut * ((int)(0.03 * amountOfMoneyAvailable) + 10);
        int normalWeekDays = 22 - weekDaysOut;
        int normalWeekDaysExpenses = normalWeekDays * 10;

        int moneyLeft = amountOfMoneyAvailable - normalWeekendDaysExpenses - goingOutExpenses 
                      - normalWeekDaysExpenses - 150;

        if (moneyLeft == 0)
        {
            Console.WriteLine("Exact Budget.");
        }
        if (moneyLeft > 0)
        {
            Console.WriteLine("Yes, leftover {0}.", moneyLeft);
        }
        if (moneyLeft < 0)
        {
            Console.WriteLine("No, not enough {0}.", Math.Abs(moneyLeft));
        }
    }
}