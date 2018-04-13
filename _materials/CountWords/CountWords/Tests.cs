using NUnit.Framework;

namespace CountWords
{
    [TestFixture]
    public class Tests
    {
        [TestCase("", 0)]
        [TestCase("a", 1)]
        [TestCase("a a", 2)]
        [TestCase("aa aa", 2)]
        [TestCase("aa", 1)]
        [TestCase(" aa ", 1)]
        [TestCase(" aa", 1)]
        [TestCase("aa ", 1)]
        [TestCase("a  a", 2)]
        [TestCase(" a a a ", 3)]
        [TestCase("asdfghjkdsfudsyugfjhgdjfs", 1)]
        [TestCase("sadsadfdsaffdsa sdafdsafsdafsd", 2)]
        [TestCase("a.b.", 2)]
        [TestCase("Hello.My.Friend.", 3)]
        [TestCase("a. b.", 2)]
        [TestCase("12", 1)]
        [TestCase("12.", 1)]
        [TestCase("12.34", 1)]
        [TestCase("And she said '12' !", 4)]
        [TestCase(null, 0)]
        [TestCase("What is that shit?", 4)]
        [TestCase("What is that shit ?", 4)]
        [TestCase("What is that shit ? ", 4)]
        [TestCase(" What is that shit ? ", 4)]
        [TestCase(" What \tis that shit ?", 4)]
        [TestCase(" What \tis that shit?", 4)]
        [TestCase(" What \tis that shit ? ", 4)]
        [TestCase(" What \nis that shit ? ", 4)]
        [TestCase("Tell me something. Anything.", 4)]
        [TestCase("12-3", 1)]
        [TestCase("12--3", 1)]
        [TestCase("12---3", 1)]
        [TestCase("12 - 3", 2)]
        [TestCase("a2a", 1)]
        [TestCase("###", 1)]
        [TestCase("#intive", 1)]
        [TestCase("# intive", 2)]
        [TestCase("a#f!", 1)]
        [TestCase("h3ll0", 1)]
        [TestCase(";!", 0)]
        [TestCase(";", 0)]
        [TestCase("var x=0;", 2)]
        [TestCase("Big-Mac", 1)]
        [TestCase("Big - Mac", 2)]
        public void MyTest(string text, int expectedWordNumber)
        {
            // Act
            int result = CountWordsClass.CountWords(text);

            // Assert
            Assert.AreEqual(expectedWordNumber, result);
        }
    }
}
