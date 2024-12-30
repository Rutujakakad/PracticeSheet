// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace StudentGrade
{//Q.9)Create a C# program that simulates a traffic light. Implement a system where the light changes based on predefined time intervals. Use conditional statements to determine which color (Red, Yellow, Green) should be displayed at any given time.
    class TrafficLight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the traffic light stimulator");
            while (true)
            {
                Console.WriteLine("RedLight - stop");
                Thread.Sleep(20000);//20sec=20000ms
                Console.WriteLine("YellowLight- slowdoen");
                Thread.Sleep(10000);
                Console.WriteLine("Greenlight- Go");
                Thread.Sleep(3000); 
            }
        }

    }
}
