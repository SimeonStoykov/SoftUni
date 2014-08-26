using System;

class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        string currentTime = Console.ReadLine();
        DateTime time = DateTime.Parse(currentTime);
        DateTime morning = new DateTime(2014, 3, 9, 8, 59, 0);
        DateTime afternoon = new DateTime(2014, 3, 9, 14, 0, 0);
        DateTime almostEvening = new DateTime(2014, 3, 9, 18, 59, 0);
        DateTime evening = new DateTime(2014, 3, 9, 19, 0, 0);
        DateTime almostMidnight = new DateTime(2014, 3, 9, 23, 59, 0);
        DateTime midnight = new DateTime(2014, 3, 9, 0, 0, 0);
        double lamp = 100.53;
        double computer = 125.90;
        int totalFlats = floors * flats;
        double electricity = 0;

        if (time.TimeOfDay >= afternoon.TimeOfDay && time.TimeOfDay <= almostEvening.TimeOfDay)
        {
            electricity = totalFlats * ((2*lamp)+(2*computer));
        }
        if (time.TimeOfDay >= evening.TimeOfDay && time.TimeOfDay <= almostMidnight.TimeOfDay)
        {
            electricity = totalFlats * ((7 * lamp) + (6 * computer));
        }
        if (time.TimeOfDay >= midnight.TimeOfDay && time.TimeOfDay <= morning.TimeOfDay)
        {
            electricity = totalFlats * ((1 * lamp) + (8 * computer));
        }

        Console.WriteLine("{0} Watts", (int)electricity);               
    }
}

