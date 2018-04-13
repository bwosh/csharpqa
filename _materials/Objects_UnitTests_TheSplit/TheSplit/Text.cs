namespace TheSplit
{
    public class Text
    {
        private string _text;

        public Text(string text)
        {
            _text = text;
        }

        public Sentence[] GetSentences()
        {
            // TODO !!!
            return null;
        }

        public int GetSentencesCount()
        {
            int result = 0;
            bool insideSentence = false;

            for (int i = 0; i < _text.Length; i++)
            {
                char character = _text[i];
                if (!TextHelper.IsSentenceEnding(character))
                {
                    if (!insideSentence && !TextHelper.IsWhiteCharacter(character))
                    {
                        insideSentence = true;
                        result++;
                    }
                }
                else
                {
                    // Is Sentence ending or white character
                    insideSentence = false;
                }
            }

            return result;
        }

        public string[] GetAllWords()
        {
            // TODO !!!
            return null;
        }

        public int GetWordCount()
        {
            int result = 0;
            bool insideWord = false;

            for (int i = 0; i < _text.Length; i++)
            {
                char character = _text[i];
                if (!TextHelper.IsWhiteCharacter(character) && !TextHelper.IsSentenceEnding(character))
                {
                    if (!insideWord)
                    {
                        insideWord = true;
                        result++;
                    }
                }
                else
                {
                    // Is Sentence ending or white character
                    insideWord = false;
                }
            }

            return result;
        }

        public string GetUniqueWordsSorted()
        {
            // TODO !!!
            return null;
        }

        public int GetUniqueWordCount()
        {
            string[] uniqueWords = new string[0];

            string currentWord = "";

            for (int i = 0; i < _text.Length; i++)
            {
                char character = _text[i];
                if (!TextHelper.IsWhiteCharacter(character) && !TextHelper.IsSentenceEnding(character))
                {
                    currentWord = currentWord + character;
                }
                else
                {
                    if (currentWord != "")
                    {
                        bool isWordFound = IsWordFound(uniqueWords, currentWord);

                        if (isWordFound)
                        {
                            currentWord = "";
                        }
                        else
                        {
                            uniqueWords = Merge(uniqueWords, currentWord);
                            currentWord = "";
                        }
                    }
                }
            }

            if (currentWord != "")
            {
                bool isWordFound = IsWordFound(uniqueWords, currentWord);

                if (!isWordFound)
                {
                    uniqueWords = Merge(uniqueWords, currentWord);
                }
            }

            return uniqueWords.Length;
        }

        private bool IsWordFound(string[] table, string word)
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == word)
                {
                    return true;
                }
            }

            return false;
        }

        private string[] Merge(string[] uniqueWords, string currentWord)
        {
            string[] newTable = new string[uniqueWords.Length + 1];

            for (int i = 0; i < uniqueWords.Length; i++)
            {
                newTable[i] = uniqueWords[i];
            }

            newTable[uniqueWords.Length] = currentWord;
            return newTable;
        }

        public string GetTheMostPopulatLetters()
        {
            CharactersCounter[] xxx;


            // TODO !!!
            return "ab";
        }

        public override string ToString()
        {
            return _text;
        }
    }

    public class CharactersCounter
    {
        private char _charactrer;
        private int _count;
    }
}