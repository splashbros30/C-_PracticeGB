// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. 
// !Использовать рекурсию, не!
// !использовать циклы.!

using System;

class Prog
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Enter a number from: ");
        int M = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter a number to: ");
        int N = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
        Console.WriteLine("Numbers from entered range:");
        range_from_numbers(M, N);
    }

    public static void range_from_numbers(int m, int n)
    {
        if (m == n + 1)
        {
            return;
        }
        Console.Write($"{m}" + (m == n ? "" : ", "));
        range_from_numbers(m + 1, n);
    }
}
