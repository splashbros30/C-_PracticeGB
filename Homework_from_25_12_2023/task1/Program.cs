﻿// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Для примера можно использовать число 322 => 322 / 7 = 46 => 322 / 23 = 14

Console.Write("Введите число для проверки = ");
int a = int.Parse(Console.ReadLine()!);

if ((a % 7 == 0) && (a % 23 == 0))
{
    Console.WriteLine("Введённое число КРАТНО 7 и 23 одновременно!");
}
else
{
    Console.WriteLine("Введённое число НЕ КРАТНО 7 и 23 одновременно!");
}