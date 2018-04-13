using System;
namespace TheSplit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Text myText = new Text("This is a text. It's not long. Yet it is powerful! Definately!!! It WILL do the magic. It will.");

            Console.WriteLine("We have a text: " + myText);
            Console.WriteLine();
            Console.WriteLine("There are " + myText.GetSentencesCount() + " sentences.");
            Console.WriteLine("There are " + myText.GetWordCount() + " words.");
            Console.WriteLine("There are " + myText.GetUniqueWordCount() + " unique words.");
            Console.WriteLine("The most popular letter is '" + myText.GetTheMostPopulatLetters() + "'.");

            Console.ReadLine();
        }
    }
}
