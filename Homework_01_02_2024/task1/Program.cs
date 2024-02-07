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
    }

    public static void range_from_numbers(int m, int n)
    {
        int i = m;
        if (i == n)
        {
            return;
        }
        Console.Write($"");
    }
}
