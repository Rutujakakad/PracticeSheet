// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace StudentGrade
{
    //Q.6)Develop a C# program that calculates the Air Quality Index (AQI) based on the concentration of pollutants. Use conditional statements to classify the AQI into different categories (Good, Moderate, Unhealthy, etc.) based on predefined thresholds for different pollutants.
    class AirQuality
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter CO concentration");
            double CO = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter NO2 concentration");
            double NO2 = double.Parse(Console.ReadLine());

            int aqiCO = CalculateAQI(CO, "CO");
            int aqiNO2 = CalculateAQI(NO2, "NO2");

            int HighestAQI = Math.Max(aqiCO, aqiNO2);

            Console.WriteLine($"Highest AQI: {HighestAQI}");
            Console.WriteLine($"AQI Classification: {GetAQICategory(HighestAQI)}");

        }
        static int CalculateAQI (double concentration, string pollutant)
        {
            int aqi = 0;
            if (pollutant == "CO")
            {
                if (concentration <= 44)
                    aqi = (int)(concentration * 5);  // Good
                else if (concentration <= 94)
                    aqi = (int)(concentration * 3);  // Moderate
                else
                    aqi = (int)(concentration * 2);  // Unhealthy
            }
            else if (pollutant == "NO2")
            {
                if (concentration <= 53)
                    aqi = (int)(concentration * 5);
                else if (concentration <= 100)
                    aqi = (int)(concentration * 3);
                else
                    aqi = (int)(concentration * 2);
            }
            return aqi;

        }

        static string GetAQICategory(int aqi)
        {
            if (aqi <= 50)
                return "Good";
            else if (aqi <= 100)
                return "Moderate";
            else if (aqi <= 200)
                return "Unhealthy";
            else
                return "Hazardous";
        }
       

    }
}
