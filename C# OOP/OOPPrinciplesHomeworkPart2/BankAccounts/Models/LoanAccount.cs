namespace BankAccounts.Models
{
    using Interfaces;
    using System;

    public class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
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
                numberOfMonths -= 3;
                if (numberOfMonths < 0)
                {
                    return 0;
                }
            }
            else if (Customer is CompanyCustomer)
            {
                numberOfMonths -= 2;
                if (numberOfMonths < 0)
                {
                    return 0;
                }
            }
            return base.CalculateInterestRate(numberOfMonths);
        }
    }
}
