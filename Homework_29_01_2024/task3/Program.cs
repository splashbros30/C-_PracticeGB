// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

using System;



class prog
{
    static Random rand = new Random();
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine()!;
        char[] characters = str.ToCharArray();
        Console.WriteLine();
        Console.WriteLine(test_for_condition(is_polindrom(characters)));
    }

    public static int is_polindrom(char[] array)
    {
        int count = 0;
        int t = array.GetLength(0) / 2;
        for (int i = 0; i < t; i++)
        {
            if (array[i] == (array[array.GetLength(0) - i - 1]))
            {
                continue;
            }
            else
            {
                count++;
            }
        }
        return count;
    }

    public static string test_for_condition(int c)
    {
        string temp = "";
        if (c != 0)
        {
            temp = "Это НЕ палиндром";
        }
        else
        {
            temp = "Это палиндром";
        }
        return temp;
    }
}