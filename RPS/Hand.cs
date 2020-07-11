using System;
using System.Linq;


namespace RPS {
    public class Hand {
        /// <summary>
        /// All valid hand strings.
        /// </summary>
        const string R = "ROCK";
        const string P = "PAPER";
        const string S = "SCISSORS";

        private readonly string[] allHands = { R, P, S };

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
                    return R;
                case 1:
                    return P;
                case 2:
                    return S;
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
                case R:
                    if (CurrentHand.Equals(S)) {
                        return 0;
                    }
                    else if (CurrentHand.Equals(P)) {
                        return 1;
                    }
                    else return -1;
                case P:
                    if (CurrentHand.Equals(R)) {
                        return 0;
                    }
                    else if (CurrentHand.Equals(S)) {
                        return 1;
                    }
                    else return -1;
                case S:
                    if (CurrentHand.Equals(P)) {
                        return 0;
                    }
                    else if (CurrentHand.Equals(R)) {
                        return 1;
                    }
                    else return -1;
                default:
                    return -2;
            }
        }
    }
}
