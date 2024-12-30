// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using LibraryReservationSystem;
namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library:");
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Check Availabilty:");
                Console.WriteLine("2.Book Reserved:");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        CheckAvailability();
                        break;
                    case 2:
                        Reserved();
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                    case 4:
                        Console.WriteLine("Invalid Input");
                        break;
                    default:
                        break;
                       
                }
            }
        }
        static List<Book> books = new List<Book>();
        static void CheckAvailability()
        {
            Console.WriteLine("Available Books");
            foreach (var book in books)
            {
                Console.WriteLine($"Book:{book.Title}, Availability: {book.IsAvailable}, Reserved or not: {book.Reserved}");
               //not showing avlability
            }
        }

        static void Reserved()
        {
            Console.WriteLine("Enter the title of book you want to reserve");
            string title = Console.ReadLine();
            var book = books.Find(x => x.Title == title);
            if (book == null)
            {
                Console.WriteLine("Book not available");
            }
            if (book.IsAvailable)
            {
                Console.WriteLine("Enter your name to reserve the book");
                string clientName = Console.ReadLine();
                Console.WriteLine($"Book of {book.Title} is reserved by {clientName}");
            }
            else
            {
                Console.WriteLine($"The book {book.Title} is reserved by {book.Reserved}");
            }
        }
    }
}