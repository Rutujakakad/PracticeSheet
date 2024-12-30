// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace StudentGrade
{
    //Q.2Develop a C# program that converts temperatures between Fahrenheit and Celsius based on user input. Use conditional statements to determine the conversion formula based on the user's choice.
    class TempConversion
    {
        public static void ConvertTemperature(double temperature, string choice)
        {
            if (choice == "CtoF") // Celsius to Fahrenheit
            {
               double C = (temperature * 9 / 5) + 32;
            }
            else if  (choice == "FtoC") // Fahrenheit to Celsius
            {
                double F =  (temperature - 32) * 5/ 9;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Fahrenheit to Celsius");
            Console.Write("Enter your choice: ");

          
            double temperature = 0;
            string TypeOfConversion;
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    TypeOfConversion = "CtoF";
                    Console.WriteLine("Enter temperature in Celsius: ");
                    //TempConversion.ConvertTemperature();
                    break;
                case 2:
                    TypeOfConversion = "FToC";
                    Console.WriteLine("Enter temperature in Fahrenheit: ");
                    break;
                default:
                    Console.WriteLine("Invalid Input3");
                    break;
            }

            //double convertedTemperature = ConvertTemperature(temperature, TypeOfConversion);
            //string result = TypeOfConversion == "CtoF" ? "Fahrenheit" : "Celsius";
            //Console.WriteLine($"Converted Temperature: {convertedTemperature:F2} {result}");
        }

    }
}