namespace TheSplit
{
    public static class TextHelper
    {
        public static bool IsSentenceEnding(char character)
        {
            if (character == '.' || character == '!' || character == '?' || character == ';')
            {
                return true;
            }
            
            return false;
        }

        public static bool IsWhiteCharacter(char character)
        {
            if (character == ' ' || character == '\t' || character == '\n')
            {
                return true;
            }

            return false;
        }
    }
}
