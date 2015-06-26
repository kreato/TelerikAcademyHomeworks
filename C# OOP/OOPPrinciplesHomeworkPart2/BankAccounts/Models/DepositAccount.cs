namespace BankAccounts.Models
{
    using Interfaces;
    using System;

    public class DepositAccount : Account, IDeposit, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }
        public void DepositAmount(decimal amount)
        {
            base.Balance += amount;
        }

        public void WithdrawAmount(decimal withdraw)
        {
            if (base.Balance == 0 || base.Balance < withdraw)
            {
                throw new ArgumentOutOfRangeException("Insufficient funds!");
            }
            base.Balance -= withdraw;
        }

        public override decimal CalculateInterestRate(int numberOfMonths)
        {
            if (base.Balance < 0 || base.Balance > 1000)
            {
                throw new ArgumentException("Balance must be between 0 nad 1000");
            }
            return base.CalculateInterestRate(numberOfMonths);
        }
    }
}
