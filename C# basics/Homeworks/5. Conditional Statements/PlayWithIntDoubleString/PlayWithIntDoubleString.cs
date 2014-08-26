using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        string choice = "Please choose a type: \n1 --> int \n2 --> double \n3 --> string";
        Console.WriteLine(choice);

        int choose = int.Parse(Console.ReadLine());

        if (choose==1)
        {
            Console.Write("Please enter an integer: ");
            int variableInt = int.Parse(Console.ReadLine());
            variableInt++;
            Console.WriteLine(variableInt);
        }
        else if (choose==2)
        {
            Console.Write("Please enter a double: ");
            double variableDouble = double.Parse(Console.ReadLine());
            variableDouble++;
            Console.WriteLine(variableDouble);
        }
        else if (choose==3)
        {
            Console.Write("Please enter a string: ");
            string variableString = Console.ReadLine();
                
            Console.WriteLine(variableString + "*");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }            
    }
}

