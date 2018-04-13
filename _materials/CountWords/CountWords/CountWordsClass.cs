namespace CountWords
{
    public class CountWordsClass
    {
        public static int CountWords(string text)
        {
            if (text == null || text == "")
            {
                return 0;
            }

            bool insideWord = false;
            int wordCounter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (SpecialCaseCharacter(text[i]))
                {
                    if (ShouleBeTreatedAsWord(text[i], text, i))
                    {
                        insideWord = true;
                    }
                    else
                    {
                        if (insideWord)
                        {
                            wordCounter++;
                            insideWord = false;
                        }
                    }
                }
                else
                {
                    if (IsWhitespaceCharacter(text[i]) || IsEndOfSentenceCharacter(text[i]))
                    {
                        if (insideWord)
                        {
                            wordCounter++;
                            insideWord = false;
                        }
                    }
                    else
                    {
                        insideWord = true;
                    }
                }
            }

            if (insideWord)
            {
                wordCounter++;
            }

            return wordCounter;
        }

        private static bool ShouleBeTreatedAsWord(char character, string text, int index)
        {
            if (character == '.')
            {
                if (IsDigit(text[index - 1]) && (text.Length > index || IsDigit(text[index + 1])))
                {
                    return true;
                }
            }

            if (character == '-')
            {
                if (IsWhitespaceCharacter(text[index - 1]))
                {
                    return false;
                }

                if (index < text.Length)
                {
                    return true;
                }

                if (IsWhitespaceCharacter(text[index + 1]))
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        private static bool IsDigit(char c)
        {
            string digits = "0123456789";
            return digits.Contains(new string(c, 1));
        }

        private static bool SpecialCaseCharacter(char c)
        {
            string endOfSentencCharacters = ".-";
            return endOfSentencCharacters.Contains(new string(c, 1));
        }

        private static bool IsEndOfSentenceCharacter(char c)
        {
            string endOfSentencCharacters = "!.?,;:-";
            return endOfSentencCharacters.Contains(new string(c, 1));
        }

        private static bool IsWhitespaceCharacter(char c)
        {
            string whitespaceCharacters = " \t\n";
            return whitespaceCharacters.Contains(new string(c, 1));
        }
    }
}
