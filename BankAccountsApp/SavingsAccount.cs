using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class SavingsAccount:BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner,decimal interestRate):base(owner + "("+interestRate+"%)") {
            
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return $"You cannot deposit ${amount}. Please enter a positive amount.";
            }
            if (amount > 20000)
            {
                return "AML deposit limit reached. Maximum deposit allowed is $20,000.";
            }

            decimal interestAmount = (InterestRate /100) * amount;
            this.Balance += amount + interestAmount;
            return $"Deposit of ${amount} completed successfully. New balance: ${Balance}.";
        }
    }
}
