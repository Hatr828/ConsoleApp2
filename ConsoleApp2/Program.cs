using System;

class Program
{
    static void Main()
    {
        string str = "x w x y x w";
        int[] charCount = new int[256]; 

        CountCharacters(str, charCount);

        Console.WriteLine("Количество вхождений каждого символа:");
        for (int i = 0; i < charCount.Length; i++)
        {
            if (charCount[i] > 0)
            {
                Console.WriteLine($"{(char)i} - {charCount[i]} раза");
            }
        }
        Console.ReadLine();
    }

    static void CountCharacters(string str, int[] charCount)
    {
        foreach (char c in str)
        {
            if (char.IsLetterOrDigit(c))
            {
                charCount[(int)c]++;
            }
        }
    }
}