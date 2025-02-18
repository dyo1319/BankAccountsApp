using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        public string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return $"You cannot deposit ${amount}. Please enter a positive amount.";
            }
            if (amount > 20000)
            {
                return "AML deposit limit reached. Maximum deposit allowed is $20,000.";
            }

            this.Balance += amount;
            return $"Deposit of ${amount} completed successfully. New balance: ${Balance}.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return $"You cannot withdraw ${amount}. Please enter a positive amount.";
            }
            if (amount > Balance)
            {
                return $"Insufficient funds. You only have ${Balance} available.";
            }

            this.Balance -= amount;
            return $"Withdrawal of ${amount} completed successfully. New balance: ${Balance}.";
        }
    }
}
