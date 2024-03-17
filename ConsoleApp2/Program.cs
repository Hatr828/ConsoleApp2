using System;

class Program
{
    delegate bool SortDelegate(int a);

    static bool isEven(int a)
    {
        return a % 2 == 0;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] filtered1 = FilterArray(numbers, (x) => x % 2 == 0);
        PrintArray(filtered1);

        int[] filtered2 = FilterArray(numbers, delegate (int x) { return x % 2 != 0; });
        PrintArray(filtered2);

        int[] filtered3 = FilterArray(numbers, isEven);
        PrintArray(filtered3);

        Console.ReadLine();
    }
    static int[] FilterArray(int[] array, SortDelegate sortFunc)
    {
        int count = 0;
        foreach (var item in array)
        {
            if (sortFunc(item))
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;
        foreach (var item in array)
        {
            if (sortFunc(item))
            {
                result[index++] = item;
            }
        }

        return result;
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}