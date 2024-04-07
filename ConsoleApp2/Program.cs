using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        int[] array = new int[10];

        for(int i = 0; i < 10; i++)
        {
            array[i] = r.Next(-100,1000);
        }
        Console.WriteLine(array.All(e => e % 2 == 0));
        Console.WriteLine(array.All(e => e > 10 && e < 45));
        Console.WriteLine(array.Any(e => e < 0));
        Console.WriteLine(array.Any(e => e < 0 && e % 2 != 0));
        Console.WriteLine(array.Contains(7));
        Console.WriteLine(array.FirstOrDefault(e => e > 723));
        Console.WriteLine(array.LastOrDefault(e => e < 0));

        Console.ReadLine();
    }
}