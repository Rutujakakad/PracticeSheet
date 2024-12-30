// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace StudentGrade
{
    internal class StudentGrade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks:");
            int marks = int.Parse(Console.ReadLine());

            if (marks >= 90 && marks <= 100)
            {
                Console.WriteLine("A");
            }
            else if (marks >= 80 && marks <= 89)
            {
                Console.WriteLine("B");
            }
            else if (marks >= 70 && marks <= 79)
            {
                Console.WriteLine("C");
            }
            else if (marks >= 60 && marks <= 69)
            {
                Console.WriteLine("D");
            }
            else if (marks >= 0 && marks <= 59)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("F");
            }   
        }
    }
}
