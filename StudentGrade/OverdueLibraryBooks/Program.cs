// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace StudentGrade
{
    //Q.8)Design a C# program that calculates the fine for overdue library books. The program should take the number of days a book is overdue as input and apply different fine rates based on predefined rules (e.g., first 7 days free, after that $0.50 per day).
    class OverdueLibraryBooks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Library Book Fine Calculator");
            Console.WriteLine("Enter the number of overdue days:");
            int overduedays = int.Parse(Console.ReadLine());
            double fine = CalculateFine(overduedays);

            Console.WriteLine($"The total fine for {overduedays} overdue days is: {fine}");

        }
        public static double CalculateFine(int days)
        {
            if (days <= 7)
            {
                return 0;
            }
            else
            {
                return (days - 7) * 0.50;
            }

        }
        
    }
}
