using System;

public class _string
{
    protected char[] line;
    protected int lenght;

    public _string(char[] line)
    {
        this.line = new char[line.Length];
        lenght = line.Length;

        for (int i = 0; i < line.Length; i++)
        {
            this.line[i] = line[i];
        }
    }
    public _string(string line)
    {
        this.line = new char[line.Length];
        lenght = line.Length;

        for (int i = 0; i < line.Length; i++)
        {
            this.line[i] = line[i];
        }
    }
    public _string(_string str)
    {
        this.line = new char[str.Length];
        lenght = str.Length;

        for (int i = 0; i < str.Length; i++)
        {
            this.line[i] = str[i];
        }
    }
    public _string(_string str, uint n)
    {
        this.line = new char[str.Length];
        lenght = str.Length;

        for (int i = 0; i < n; i++)
        {
            this.line[i] = str[i];
        }
    }
    public _string(char[] line, uint n)
    {
        this.line = new char[n];
        lenght = Convert.ToUInt16(n);

        for (int i = 0; i < n; i++)
        {
            this.line[i] = line[i];
        }
    }
    public _string(uint size)
    {
        line = new char[size];
        lenght = Convert.ToUInt16(size);
    }
    public _string()
    {
        line = new char[25];
    }

    public char this[int number]
    {
        get
        {
                return line[number];
        }
        set
        {
            if (line.Length < number)
            {
                line[number] = value;
            }
        }
    }
    public int Length
    {
        get
        {
            return lenght;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        _string str = new _string("Hello world");
        Console.WriteLine($"String: {str[2]}. Length: {str.Length}");
        _string str2 = new _string(str, 6);
        Console.WriteLine($"String: {str2[4]}. Length: {str2.Length}");
        _string str3 = new _string(10);
        Console.WriteLine($"String: {str3[5]}. Length: {str3.Length}");

        Console.ReadLine();
    }
}