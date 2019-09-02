using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsCarRace;

namespace SportsCarRaceUnitTest
{
    [TestClass]
    public class SportsCarUnitTest
    {
        [TestMethod]
        public void Payout_Unit_Test()
        {
            // Arrange
            var bet = new Bet();

            // Act
            var actual = bet.PayOut(1);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Check_Amount_More_Than_Zero()
        {
            // Arrange
            var guy = new Bettor();

            // Act
            var actual = guy.PlaceBid(10, 1);

            // Assert
            Assert.IsTrue(!actual);
        }
    }
}
