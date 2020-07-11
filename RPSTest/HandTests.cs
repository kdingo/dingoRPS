using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;

namespace RPSTest {
    [TestClass]
    public class HandTests {

        [TestMethod]
        public void GenerateHandTest() {
            //Arrange
            string[] validHand = { "ROCK", "PAPER", "SCISSORS" };
            var newHand = new Hand();

            //Act
            var actualHand = newHand.CurrentHand;

            //Assert
            CollectionAssert.Contains(validHand, actualHand);
        }

        [TestMethod]
        public void ConstructorHandTest() {
            //Arrange
            var expectedHand = "ROCK";
            var newHand = new Hand("Rock");

            //Act
            var actualHand = newHand.CurrentHand;

            //Assert
            Assert.AreEqual(expectedHand, actualHand);
        }

        [TestMethod]
        public void IsWinnerTest() {
            //Arrange
            var hand1 = new Hand("Rock");
            var hand2 = new Hand("Scissors");
            var hand3 = new Hand("rock");
            var expectedWin = 1;
            var expectedLoss = 0;
            var expectedDraw = -1;

            //Act
            var actualHand1 = hand1.IsWinner(hand2);
            var actualHand2 = hand2.IsWinner(hand1);
            var actualHand3 = hand1.IsWinner(hand3);

            //Assert
            Assert.AreEqual(actualHand1, expectedWin);
            Assert.AreEqual(actualHand2, expectedLoss);
            Assert.AreEqual(actualHand3, expectedDraw);

        }
    }
}
