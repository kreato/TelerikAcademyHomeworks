namespace BankAccounts.Models
{
    using Interfaces;
    using System;

    public class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }
        public void DepositAmount(decimal amount)
        {
            base.Balance += amount;
        }

        public override decimal CalculateInterestRate(int numberOfMonths)
        {
            if (numberOfMonths < 0)
            {
                throw new ArgumentException("Number of months must be positive");
            }
            if (Customer is IndividualCustomer)
            {
                numberOfMonths -= 6;
                if (numberOfMonths < 0)
                {
                    return 0;
                }
            }
            else if (Customer is CompanyCustomer)
            {
                if (numberOfMonths <= 12)
                {
                    return 0.5M * base.CalculateInterestRate(numberOfMonths);
                }
                else
                {
                    return (0.5M * base.CalculateInterestRate(12)) + base.CalculateInterestRate(numberOfMonths - 12);
                }
            }
            return base.CalculateInterestRate(numberOfMonths);
        }
    }
}
