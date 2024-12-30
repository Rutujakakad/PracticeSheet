// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace StudentGrade
{
    //Q.3) Design a simple login system in C# where users provide their username and password. Use conditional statements to check the credentials and provide appropriate feedback, such as successful login, incorrect username, incorrect password, or account locked.
    class  LoginSystem
    {
        static string Username = "xyz234";
        static string Password = "Password123";

        static int maxiAttempt = 3;
        static int attempt = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the login System.");

            while(attempt < maxiAttempt)
            {
                Console.WriteLine("Enter Username:");
                string enteredUsername = Console.ReadLine();

                Console.WriteLine("Enter Password:");
                string enteredPassword = Console.ReadLine();

                if (enteredUsername == Username && enteredPassword == Password)
                {
                    Console.WriteLine("Login Successful");
                }
                else if (enteredUsername != Username )
                {
                    Console.WriteLine("Invalid Username");
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }
                attempt++;
                Console.WriteLine($"Attempts Remaining: {maxiAttempt - attempt}\n");

                
            }
            Console.WriteLine("Account Locked.");
        }
    }
}
