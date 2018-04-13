using Microsoft.VisualStudio.TestTools.UnitTesting;

using TheSplit;

namespace TheSplitTests
{
    [TestClass]
    public class SentenceTests
    {
        // ProperConstructor_and_ToString
        [TestMethod]
        public void SingleSentence()
        {
            // Arrange
            string text = "Ala ma kota.";
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(1, sentences);
        }

        [TestMethod]
        public void SingleSentenceNoDot()
        {
            // Arrange
            string text = "Ala ma kota";
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(1, sentences);
        }

        [TestMethod]
        public void NoText()
        {
            // Arrange
            string text = "";
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(0, sentences);
        }

        [TestMethod]
        public void SingleCharacter()
        {
            // Arrange
            string text = "x";
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(1, sentences);
        }

        [TestMethod]
        public void Zwei()
        {
            // Arrange
            string text = "Oh no. Was ist das?";
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(2, sentences);
        }

        [TestMethod]
        public void Zwei_NoEnding()
        {
            // Arrange
            string text = "Oh no. Was ist das";
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(2, sentences);
        }

        [TestMethod]
        public void Zwei_ButSpaceOnTheEnd()
        {
            // Arrange
            string text = "Oh no. Was ist das? ";
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(2, sentences);
        }

        [TestMethod]
        public void Speced()
        {
            // Arrange
            string text = "        hey     ";
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(1, sentences);
        }

        [TestMethod]
        public void NoSpace()
        {
            // Arrange
            string text = "Oh no.Was ist das? ";
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(2, sentences);
        }

        [TestMethod]
        public void Number()
        {
            // Arrange
            string text = "13"; // A Derez mówił "13.5 tralala"
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(1, sentences);
        }

        [TestMethod]
        public void DontKnow()
        {
            // Arrange
            string text = "..a.."; 
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(1, sentences);
        }

        [TestMethod]
        public void SomeKindOfMonster()
        {
            // Arrange
            string text = "....";
            Text myText = new Text(text);

            // Act
            int sentences = myText.GetSentencesCount();

            // Assert
            Assert.AreEqual(0, sentences);
        }

        [TestMethod]
        public void WordCount_MainScenario()
        {
            // Arrange
            string text = "Main scenario";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetWordCount();

            // Assert
            Assert.AreEqual(2, wordCount);
        }
        [TestMethod]
        public void WordCount_MainScenarioDot()
        {
            // Arrange
            string text = "Main scenario.";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetWordCount();

            // Assert
            Assert.AreEqual(2, wordCount);
        }

        [TestMethod]
        public void WordCount_TwoSentences()
        {
            // Arrange
            string text = "Main scenario. Next sentence.";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetWordCount();

            // Assert
            Assert.AreEqual(4, wordCount);
        }

        [TestMethod]
        public void WordCount_TwoSentences_NoSpace()
        {
            // Arrange
            string text = "Main scenario.Next sentence.";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetWordCount();

            // Assert
            Assert.AreEqual(4, wordCount);
        }

        [TestMethod]
        public void WordCount_Empty()
        {
            // Arrange
            string text = "";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetWordCount();

            // Assert
            Assert.AreEqual(0, wordCount);
        }

        [TestMethod]
        public void WordCount_WhiteCharacters()
        {
            // Arrange
            string text = "   ";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetWordCount();

            // Assert
            Assert.AreEqual(0, wordCount);
        }

        [TestMethod]
        public void WordCount_KillHim()
        {
            // Arrange
            string text = "y u i d f g t w q e a z x c v b n j i o 2 4 5";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetWordCount();

            // Assert
            Assert.AreEqual(23, wordCount);
        }

        [TestMethod]
        public void UniqueWords_OneWord()
        {
            // Arrange
            string text = "one";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(1, wordCount);
        }

        [TestMethod]
        public void UniqueWords_TwoSame()
        {
            // Arrange
            string text = "one one";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(1, wordCount);
        }

        [TestMethod]
        public void UniqueWords_TwoAlmostSame()
        {
            // Arrange
            string text = "oneX one";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(2, wordCount);
        }

        [TestMethod]
        public void UniqueWords_TwoAlmostSame2()
        {
            // Arrange
            string text = "one oneX";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(2, wordCount);
        }

        [TestMethod]
        public void UniqueWords_DifferentLocations()
        {
            // Arrange
            string text = "one two one two one two one";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(2, wordCount);
        }

        [TestMethod]
        public void UniqueWords_Same_Characters()
        {
            // Arrange
            string text = "x x x x x x x x x x x x";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(1, wordCount);
        }

        [TestMethod]
        public void UniqueWords_DotSeparator()
        {
            // Arrange
            string text = "one.one";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(1, wordCount);
        }

        [TestMethod]
        public void UniqueWords_DotSeparator2()
        {
            // Arrange
            string text = "one.one.";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(1, wordCount);
        }

        [TestMethod]
        public void UniqueWords_DotSeparatorWithSpace()
        {
            // Arrange
            string text = "one. one.";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(1, wordCount);
        }

        [TestMethod]
        public void UniqueWords_MisspeledDot()
        {
            // Arrange
            string text = "o.ne. one.";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(3, wordCount);
        }

        [TestMethod]
        public void UniqueWords_Nothing()
        {
            // Arrange
            string text = "";
            Text myText = new Text(text);

            // Act
            int wordCount = myText.GetUniqueWordCount();

            // Assert
            Assert.AreEqual(0, wordCount);
        }
    }
}
