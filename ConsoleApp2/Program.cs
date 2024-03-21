using System;

public interface ICipher
{
    string Encode(string input);
    string Decode(string input);
}

public class Cipher : ICipher
{
    private const int shift = 2; // Количество бит для сдвига

    public string Encode(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            charArray[i] = (char)(charArray[i] << shift);
        }

        return new string(charArray);
    }

    public string Decode(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            charArray[i] = (char)(charArray[i] >> shift);
        }

        return new string(charArray);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICipher cipher = new Cipher();

        string originalString = "Hello, World!";
        string encryptedString = cipher.Encode(originalString);
        string decryptedString = cipher.Decode(encryptedString);

        Console.WriteLine("1    " + originalString);
        Console.WriteLine("2    " + encryptedString);
        Console.WriteLine("3    " + decryptedString);

        Console.ReadLine();
    }
}