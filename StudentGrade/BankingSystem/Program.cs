// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using BankingSystem;
using Microsoft.VisualBasic;
namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to banking System:");

            SavingAccount saving = new SavingAccount("H3158", "Alex", 1000);
            CheckingAccount check = new CheckingAccount("A256", "Jphn", 500);

            Console.WriteLine(" Savings Account Operations ");
            saving.DisplayBalance();
            saving.Deposite(500);
            saving.Withdraw(800);
            saving.Withdraw(300);
            Console.WriteLine("Checking Account Operations");
            check.DisplayBalance();
            check.Deposite(200);
        }
    }

}
