using CodeToTest;
using NUnit.Framework;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void SampleTest()
        {
            // Assign
            ClassToTest ctt = new ClassToTest();
            var expectedValue = "NotSoGood";

            // Act
            var result = ctt.Check();

            // Assert
            Assert.AreEqual(expectedValue, result);
        }


    }
}
