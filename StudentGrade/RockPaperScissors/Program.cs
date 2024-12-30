// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace StudentGrade
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            
            string[] options = { "Rock", "Paper", "Scissors" };
            Random rndm = new Random();
            int roll = rndm.Next(0, 3);
            string machineChoice = options[roll];

            Console.WriteLine("Enter your choice(Rock, Paper, Scissors)");
            string choiceOfPlayer = Console.ReadLine();

            if (choiceOfPlayer != "Rock" && choiceOfPlayer != "Paper" && choiceOfPlayer != "Scissors")
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine($"YourChoice:{choiceOfPlayer}");
            Console.WriteLine($"MachineChoice: {machineChoice}");

            if (choiceOfPlayer == machineChoice)
            {
                Console.WriteLine("Tie");
            }
            else if ((choiceOfPlayer == "rock" && machineChoice == "Scissors") ||
                (choiceOfPlayer == "scissors" && machineChoice == "Paper") ||
                (choiceOfPlayer == "paper" && machineChoice == "Rock"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Machine Wins!");
            }
        }
       

    }
}