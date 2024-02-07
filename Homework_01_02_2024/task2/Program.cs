// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

using System;

class Prog
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Enter a first number of function:");
        int M = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter a second number of function:");
        int N = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
        Console.WriteLine("Function of Ackermann:");
        Console.WriteLine(ack(M, N));
    }

    public static int ack(int m, int n)
    {
        int func = 0;

        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            func = ack(m - 1, 1);
            return func;
        }
        else if (m > 0 && n > 0)
        {
            func = ack(m - 1, ack(m, n - 1));
            return func;
        }
        return func;
    }
}