using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Simeon";
        string familyName = "Stoykov";
        byte age = 23;
        char gender = 'm';
        long personalNumber = 8306112507;
        int uniqueEmployeeNumber = 27560500;
        Console.WriteLine("Name: {0} {1} \nAge= {2} \nSex= {3} \nPersonal Number= {4} \nUnique Emploee Number= {5}", 
        firstName, familyName, age, gender, personalNumber, uniqueEmployeeNumber);
    }
}

