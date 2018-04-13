using NUnit.Framework;

namespace TheCalculatorProject.Tests
{
    [TestFixture]
    public class MathHelperTests
    {
        [Test]
        public void BiggestCommonDivider_SameValue()
        {
            // Arrange
            int a = 50;
            int b = 50;

            // Act
            int result = MathHelper.BiggestCommonDivider(a, b);

            // Assert
            Assert.AreEqual(50, result);
        }

        [Test]
        public void BiggestCommonDivider_DifferntValues()
        {
            // Arrange
            int a = 38;
            int b = 18;

            // Act
            int result = MathHelper.BiggestCommonDivider(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void BiggestCommonDivider_NoDividers()
        {
            // Arrange
            int a = 2003;
            int b = 2011;

            // Act
            int result = MathHelper.BiggestCommonDivider(a, b);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void BiggestCommonDivider_LotsOfDividers()
        {
            // Arrange
            int a = 60;
            int b = 24;

            // Act
            int result = MathHelper.BiggestCommonDivider(a, b);

            // Assert
            Assert.AreEqual(12, result);
        }

        [Test]
        public void BiggestCommonDivider_TwoOnes()
        {
            // Arrange
            int a = 1;
            int b = 1;

            // Act
            int result = MathHelper.BiggestCommonDivider(a, b);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void BiggestCommonDivider_LotsOfDividers_FirstNegative()
        {
            // Arrange
            int a = -60;
            int b = 24;

            // Act
            int result = MathHelper.BiggestCommonDivider(a, b);

            // Assert
            Assert.AreEqual(12, result);
        }

        [Test]
        public void BiggestCommonDivider_LotsOfDividers_SecondNegative()
        {
            // Arrange
            int a = 60;
            int b = -24;

            // Act
            int result = MathHelper.BiggestCommonDivider(a, b);

            // Assert
            Assert.AreEqual(12, result);
        }

        [Test]
        public void BiggestCommonDivider_LotsOfDividers_BothNegative()
        {
            // Arrange
            int a = -60;
            int b = -24;

            // Act
            int result = MathHelper.BiggestCommonDivider(a, b);

            // Assert
            Assert.AreEqual(12, result);
        }
    }
}
