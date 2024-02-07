// Задание 2. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.

using System;

class Prog()
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Enter a number: ");
        int N = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
        Console.WriteLine($"All natural numbers from 1 to {N} :");
        all_natutal_numbers(N, N);
    }

    public static void all_natutal_numbers(int number, int n)
    {
        if (number == 0)
        {
            return;
        }
        all_natutal_numbers(number - 1, n);
        Console.Write($"{number}" + (number == n ? "" : " "));
    }
}