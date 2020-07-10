using System;
using System.Linq;


namespace RPS {
    public class Hand {
        private readonly string[] allHands = { "ROCK", "PAPER", "SCISSORS" };
        private string currentHand;

        public Hand() {
            CurrentHand = GenerateHand();
        }

        public Hand(string choiceHand) {
            CurrentHand = choiceHand.ToUpper().Trim();
            if (!allHands.Contains(CurrentHand)) {
                CurrentHand = GenerateHand();
            }
        }

        public string CurrentHand {
            get {
                return currentHand;
            }
            set {
                currentHand = value;
            }
        }

        private string GenerateHand() {
            Random randgen = new Random();
            int choiceint = randgen.Next(0, 2);
            switch (choiceint) {
                case 0:
                    return "ROCK";
                case 1:
                    return "PAPER";
                case 2:
                    return "SCISSORS";
                default:
                    return "default";
            }
        }

        public int IsWinner(Hand opponentHand) {
            //1 = this hand is a Winner
            //0 = this hand loses
            //-1 = draw

            string compareHand = opponentHand.CurrentHand;

            switch (compareHand) {
                case "ROCK":
                    if (CurrentHand.Equals("SCISSORS")) {
                        return 0;
                    }
                    else if (CurrentHand.Equals("PAPER")) {
                        return 1;
                    }
                    else return -1;
                case "PAPER":
                    if (CurrentHand.Equals("ROCK")) {
                        return 0;
                    }
                    else if (CurrentHand.Equals("SCISSORS")) {
                        return 1;
                    }
                    else return -1;
                case "SCISSORS":
                    if (CurrentHand.Equals("PAPER")) {
                        return 0;
                    }
                    else if (CurrentHand.Equals("ROCK")) {
                        return 1;
                    }
                    else return -1;
                default:
                    return -2;
            }
        }
    }
}
