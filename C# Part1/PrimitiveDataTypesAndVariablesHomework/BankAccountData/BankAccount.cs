//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
using System;
class BankAccount
{
    static void Main()
    {
        string firstName = "Jonathan";
        string middleName = @"""Jon""";
        string lastName = "Lajoie";
        int balance = 9390531;
        char currency = '\u0024';
        string bankName = "Laurentian Bank of Canada";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        long creditCard1 = 6646097387128875;
        long creditCard2 = 6767544532098712;
        long creditCard3 = 5438294956838950;
        Console.WriteLine("This is the bank account of:\nFirst name: {0}\nMiddle name: {1}\nLast name: {2}\nTotal amount of money: {3}{4}\nBank name: {5}\nIBAN: {6}\nFirst credit card number: {7}\nSecond credit card number: {8}\nThird credit card number: {9}",firstName,middleName,lastName,balance,currency,bankName,iban,creditCard1,creditCard2,creditCard3);
    }
}