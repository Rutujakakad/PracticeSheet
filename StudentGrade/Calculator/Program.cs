// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace StudentGrade
{    //Calculator
    class Calculator
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            int choice;

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int ch = int.Parse(Console.ReadLine());
                if (ch < 5)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");

                }
                if (ch == 5)
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }
                Console.Write("Enter first number: ");
                num1 = double.Parse(Console.ReadLine());
                if (num1 < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");

                }

                Console.Write("Enter second number: ");
                num2 = double.Parse(Console.ReadLine());
                if (num2 < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                switch (ch)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;

                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;

                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;

                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}

