using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class SavingAccount : BankAccount
    {
        public SavingAccount(string accountNumber, string accountHolderName, double Balance) : base(accountNumber, accountHolderName, Balance) { }
        private const double MinimumBalance = 500.0;

        public override void Withdraw(double amount)
        {
            if (Balance - amount < MinimumBalance)
            {
                Console.WriteLine("Withdrawal denied. Minimum balance should be 500");
            }
            base.Withdraw(amount);
        }
    }
}
