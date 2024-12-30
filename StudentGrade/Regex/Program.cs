// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Text.RegularExpressions;
namespace StudentGrade
{  //
    class Program
    {//Q.24)As a system administrator, I want a regex pattern to validate usernames. Usernames should consist of an uppercase first letter followed by exactly two lowercase letters. This ensures a consistent and easily readable username format
        static void Main(string[] args)
        {
            //string pattern = @"^[A-Z]{1}[a-z]{2}$";
            //Console.WriteLine("Enter the Name");
            //string name = Console.ReadLine();
            //if (Regex.IsMatch(name, pattern))
            //{
            //    Console.WriteLine("Name is valid ");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter valid input");
            //}


            //Q.25)As a system administrator, I want a regex pattern to validate usernames. Usernames should consist of an uppercase first letter followed by exactly two lowercase letters. This ensures a consistent and easily readable username format
            string pattern = @"\b(?:https?://)?(?:www\.)?[a-zA-Z0-9-]+\.[a-zA-Z]{2,}(?:/[^\s]*)";//?=> matches 0 or 1 occurance of the pattern left to it
            
            Console.WriteLine("Enter the website");
            string website = Console.ReadLine();
            if(Regex.IsMatch(website, pattern))
            {
                Console.WriteLine("URL Found");
            }

            //Q.26)Date Format

            string inputDate1 = "The date 2024-10-24 should be in this format";
            string patternFormat1 = @"^\d{4}-\d{2}-\d{2}";

            string inputDate2 = "The date should be in MM/DD/YYYY format";
            string patternFormat2 = @"^\d{2}-\d{2}-\d{4}";

            string inputDate3 = "The date shoould be in Month DD, YYYY format";
            string patternFormat3 = @"[A - Za - z] + /d{2}, / d{4}";

            if (Regex.IsMatch(inputDate1, patternFormat1))
            {
                Console.WriteLine("Enter Date");
                string date = Console.ReadLine();
            }
            if (Regex.IsMatch(inputDate2, patternFormat2))
            {
                Console.WriteLine("Enter Date");
                string date = Console.ReadLine();
            }
            if (Regex.IsMatch(inputDate2, patternFormat2))
            {
                Console.WriteLine("Enter Date");
                string date = Console.ReadLine();
            }
        }
    }
}
