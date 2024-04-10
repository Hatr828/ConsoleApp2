using System;
using System.IO;
using System.Linq;

public static class StringExtensions
{
    public static string CapitalizeSentences(this string input)
    {
        var sentences = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        var capitalizedSentences = sentences.Select(sentence =>
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return sentence; 

            return char.ToUpper(sentence[0]) + sentence.Substring(1);
        });

        return string.Join(". ", capitalizedSentences) + ".";
    }
}

class Program
{
    static void Main(string[] args)
    {
        string filePath = "test.txt";                                       

        string text = File.ReadAllText(filePath);

        string capitalizedText = text.CapitalizeSentences();

         Console.WriteLine(capitalizedText);
        Console.ReadLine();
    }
}