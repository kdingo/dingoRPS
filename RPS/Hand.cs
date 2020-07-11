using System;
using System.Linq;


namespace RPS {
    public class Hand {
        /// <summary>
        /// An array of valid hand strings.
        /// </summary>
        private readonly string[] allHands = { "ROCK", "PAPER", "SCISSORS" };

        private string currentHand;

        /// <summary>
        /// Default constructor. Invoking with no parameters generates a hand by random.
        /// </summary>
        public Hand() {
            CurrentHand = GenerateHand();
        }

        /// <summary>
        /// Constructor. Provide a string of your choice of hand. Must be valid or
        /// a valid one is generated.
        /// </summary>
        /// <param name="choiceHand"></param>
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

        /// <summary>
        /// Randomly generates a valid hand.
        /// </summary>
        /// <returns>A string of a valid hand.</returns>
        private string GenerateHand() {
            Random randgen = new Random();
            int choiceint = randgen.Next(0, 3);
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

        /// <summary>
        /// Compares this hand against another hand. Returns an int representing
        /// the result of the comparison.
        /// 1 = this hand is a Winner
        /// 0 = this hand loses
        /// -1 = draw
        /// </summary>
        /// <param name="opponentHand"></param>
        /// <returns>An int of the comparison result.</returns>
        public int IsWinner(Hand opponentHand) {
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
