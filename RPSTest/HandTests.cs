using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;

namespace RPSTest {
    [TestClass]
    public class HandTests {
        readonly string[] expectedHand = { "ROCK", "PAPER", "SCISSORS" };

        [TestMethod]
        public void GenerateHandTest() {
            //Arrange
            var newHand = new Hand();

            //Act
            var actualHand = newHand.CurrentHand;

            //Assert
            CollectionAssert.Contains(expectedHand, actualHand);
        }

        [TestMethod]
        public void ConstructorHandTest() {
            //Arrange
            var newHand = new Hand("Rock");

            //Act
            var actualHand = newHand.CurrentHand;

            //Assert
            CollectionAssert.Contains(expectedHand, actualHand);
        }

        [TestMethod]
        public void IsWinnerTest() {
            //Arrange
            var hand1 = new Hand("Rock");
            var hand2 = new Hand("Scissors");
            var expected = 1;

            //Act
            var actualHand1 = hand1.IsWinner(hand2);

            //Assert
            Assert.AreEqual(actualHand1, expected);
        }
    }
}
