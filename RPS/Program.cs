using System;

namespace RPS {
    class Program {
        static void Main(string[] args) {
            Hand computerHand = new Hand();

            Console.WriteLine("Rock, Paper, Scissors!\n" +
                "dingo, 20200708\n" +
                "Computer has chosen. Choose a Hand.");

            string readChoice = Console.ReadLine();

            Hand playerHand = new Hand(readChoice);

            Console.WriteLine("You chose: " + playerHand.CurrentHand);
            Console.WriteLine("Computer chose: " + computerHand.CurrentHand);

            int result = playerHand.IsWinner(computerHand);

            switch (result) {
                case 1:
                    Console.WriteLine("You won!");
                    break;
                case 0:
                    Console.WriteLine("You lost.");
                    break;
                case -1:
                    Console.WriteLine("Draw.");
                    break;
                case -2:
                    Console.WriteLine("Invalid Hand Played");
                    break;
                default:
                    Console.WriteLine("Invalid result");
                    break;
            }
        }
    }
}
