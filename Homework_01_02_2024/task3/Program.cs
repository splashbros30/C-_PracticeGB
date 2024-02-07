// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

using System;

class Prog
{
    public static Random rand = new();
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Enter the number of digits in the array:");
        int N = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter the number to star the array with:");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter the number at which the array will end:");
        int b = int.Parse(Console.ReadLine()!);
        int[] array = create_array(N, a, b);
        Console.WriteLine();
        Console.WriteLine("Created array:");
        show_array(array);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Reversed array:");
        revers_array(array, N);
    }

    public static int[] create_array(int n, int from, int to)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(from, to); 
        }
        return arr;
    }

    public static void show_array(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]}" + (i == (arr.Length - 1) ? "]" : ", "));
        }
    }

    public static void revers_array(int[] arr, int n)
    {
        if (n == 0)
        {
            return;
        }
        Console.Write(((n - 1) == (arr.Length - 1) ? "[" : "") + arr[n - 1] + ((n - 1) == 0 ? "]" : ", "));
        revers_array(arr, n - 1);
    }
}