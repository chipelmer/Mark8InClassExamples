using System;
using Xunit;

namespace Mark8InClassExamples.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Test", "Test")]
        [InlineData("Chip's Lemos", "Chip's Lemos")]
        [InlineData("An Incredible Lemonade Stand!", "An Incredible Lemonade Stand!")]
        [InlineData("", "")]
        [InlineData(null, "")]
        public void NewStandShouldHaveName(string standName, string expected)
        {
            // Arrange
            LemonadeStand stand = new LemonadeStand(standName);

            // Act
            string actual = stand.Name;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0.20, 1.00, 100, 80)]
        [InlineData(0.50, 0.50, 1000, 0)]
        [InlineData(0.00, 1.00, 1000, 1000)]
        [InlineData(0.75, 0.50, 10000, -2500)]
        public void ShouldCalculateProfit(decimal costPerCup, decimal pricePerCup, int numberOfCupsSold, decimal expected)
        {
            // Arrange
            LemonadeStand stand = new LemonadeStand("");
            stand.CostPerCup = costPerCup;
            stand.PricePerCup = pricePerCup;
            stand.NumberOfCupsSold = numberOfCupsSold;

            // Act
            decimal actual = stand.GetTotalProfit();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
