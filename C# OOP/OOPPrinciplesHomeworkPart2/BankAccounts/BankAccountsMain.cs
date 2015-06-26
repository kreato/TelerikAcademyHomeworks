namespace BankAccounts
{
    using Models;
    using System;
    using System.Collections.Generic;
    public class BankAccountsMain
    {
        static void Main()
        {
            List<Customer> customers = new List<Customer>
            {
                new IndividualCustomer("Pepo"),
                new IndividualCustomer("Tsura"),
                new IndividualCustomer("Vaso"),
                new CompanyCustomer("Software AG"),
                new CompanyCustomer("C3i"),
                new CompanyCustomer("Schneider Electric")
            };

            DepositAccount pepoDepAcc = new DepositAccount(customers[0], 300, 30);
            pepoDepAcc.DepositAmount(80);
            pepoDepAcc.WithdrawAmount(120);
            Console.WriteLine("Pepo's balance: {0}", pepoDepAcc.Balance);
            Console.WriteLine("Calculate Pepo's interest rate: {0}", pepoDepAcc.CalculateInterestRate(10));

            LoanAccount tsuraLoanAcc = new LoanAccount(customers[1], 800, 70);
            tsuraLoanAcc.DepositAmount(489);
            Console.WriteLine("Tsura's balance: {0}", tsuraLoanAcc.Balance);
            Console.WriteLine("Calculate Tsura's interest rate: {0}", tsuraLoanAcc.CalculateInterestRate(2));

            MortgageAccount vasoMortAcc = new MortgageAccount(customers[2], 500, 20);
            vasoMortAcc.DepositAmount(1000);
            Console.WriteLine("Vaso's balance: {0}", vasoMortAcc.Balance);
            Console.WriteLine("Calculate Vaso's interest rate: {0}", vasoMortAcc.CalculateInterestRate(12));

            DepositAccount softAgDepAcc = new DepositAccount(customers[3], 20000, 30);
            softAgDepAcc.DepositAmount(1000);
            softAgDepAcc.WithdrawAmount(20000);
            Console.WriteLine("Software AG's balance: {0}", softAgDepAcc.Balance);
            Console.WriteLine("Calculate Software AG's interest rate: {0}", softAgDepAcc.CalculateInterestRate(2));

            LoanAccount c3iLoanAcc = new LoanAccount(customers[4], 15000, 20);
            c3iLoanAcc.DepositAmount(700);
            Console.WriteLine("C3i's balance: {0}", c3iLoanAcc.Balance);
            Console.WriteLine("Calculate C3i's interest rate: {0}", c3iLoanAcc.CalculateInterestRate(10));

            MortgageAccount schneiderMortAcc = new MortgageAccount(customers[5], 90000, 50);
            schneiderMortAcc.DepositAmount(10000);
            Console.WriteLine("Schneider Electric's balance: {0}", schneiderMortAcc.Balance);
            Console.WriteLine("Calculate Schneider Electric's interest rate: {0}", schneiderMortAcc.CalculateInterestRate(20));
        }
    }
}
