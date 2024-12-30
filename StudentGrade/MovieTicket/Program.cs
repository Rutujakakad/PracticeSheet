// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace StudentGrade
{
    //Q.3)Write a C# program that calculates the price of a movie ticket based on the age of the customer and the time of the movie. Implement different pricing rules for children (under 12), adults (12-64), and seniors (65+), and consider matinee discounts.
    class MovieTicket
    {
         static double ticketPrice;
        public static double CalculateTicketPrice(int age, int time)
        {
            if (age <= 12)// for children
            {
                ticketPrice = 10.0;
            }
            else if (age >= 65)
            {
                ticketPrice = 15.0;//seniors
            } 
            else
            {
                ticketPrice = 30.0;//adults
            }

            if (time < 1700) // Matinee before 5:00PM
            {
                ticketPrice -= 3.0;
            }

            return ticketPrice;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Movie Ticket Pricing");
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Invalid age input. Please enter positive number.");
            }
            Console.Write("Enter the movie time (in 24-hour format, example: 1400 input for 2:00 PM): ");
            int time = int.Parse(Console.ReadLine());
            if (time < 0 || time > 2359)
            {
                Console.WriteLine("Invalid time input. Please enter a valid 24-hour time (0000 to 2359).");

            }
            double price = CalculateTicketPrice(age, time);
            Console.WriteLine($"Your ticket price is: {price}");

        }
    }
}