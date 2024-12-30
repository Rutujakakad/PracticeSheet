using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string AccountHolderName { get; private set; }
        protected double Balance;

        public BankAccount(string accountNumber, string accountHolderName, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

        public virtual void Deposite(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Balance is null");
            }

            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount of withdrawal must be positive");
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New Balance: {Balance}");
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Account: {AccountNumber}, Balance: {Balance}");
        }
    }
    
}
