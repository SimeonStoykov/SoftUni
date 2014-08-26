using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Simeon";
        string middleName = "Petkov";
        string lastName = "Stoykov";
        decimal balance = 200000.55m;
        string bankName = "DSK";
        string iban = "BG30GG556688998855221155446655";
        long cardNumber = 4444555566668888;

        Console.WriteLine("{0} {1} {2}, {3}, {4}, {5}, {6}", firstName, middleName, lastName, balance, bankName, iban, 
                          cardNumber);
    }
}
