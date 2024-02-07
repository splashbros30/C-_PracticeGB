// Задание 1. Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// Указание
// Использовать рекурсию.


using System;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
        Console.WriteLine("Summ of digits of number: ");
        Console.WriteLine(summ(n));
    }

    public static int summ(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        return summ(number / 10) + number % 10;
    }
}