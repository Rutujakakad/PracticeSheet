using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNumber, string accountHolderName, double initialBalance)
            : base(accountNumber, accountHolderName, initialBalance) { }

        private const double OverdraftLimit = 1000.0;

        public override void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal denied. Amount must be greater than zero.");
            }
            base.Withdraw(amount);
            Console.WriteLine($"Withdrawal of {amount} successful. Remaining balance: {Balance}");
        }
    }
}
