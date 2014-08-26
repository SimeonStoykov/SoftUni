using System;

class DifferenceBetweenDates
{
    static void Main()
    {           
        DateTime start = DateTime.Parse(Console.ReadLine()); //Works for all date formats - 18.03.2014, 18/03/2014 etc.
        DateTime end = DateTime.Parse(Console.ReadLine());

        Console.WriteLine((end - start).TotalDays);         
    }
}

//ALTERNATIVE SOLUTION

//string format = "dd.MM.yyyy";

//Console.WriteLine("Enter date in format - dd.MM.yyyy");
//string DateOne = Console.ReadLine();
//DateTime dateOne = DateTime.ParseExact(DateOne, format, CultureInfo.InvariantCulture); //-> For exact date format

//string DateTwo = Console.ReadLine();
//DateTime dateTwo = DateTime.ParseExact(DateTwo, format, CultureInfo.InvariantCulture);           

//Console.WriteLine((dateTwo - dateOne).TotalDays);
