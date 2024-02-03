// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

using System;



class prog
{
    static Random rand = new Random();
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите размерность массива:");
        Console.WriteLine("Количество строк:");
        char row = (char)(int.Parse(Console.ReadLine()!));
        Console.WriteLine("Количество столбцов:");
        char col = (char)(int.Parse(Console.ReadLine()!));
        Console.WriteLine();
        char[,] arr = create_array(row, col);
        print_array(arr);
        Console.WriteLine();
        Console.WriteLine(char_to_string(arr));
    }

    public static string char_to_string(char[,] array)
    {
        string str = "[";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                str = str + array[i, j] + (((i < array.GetLength(0) - 1) || (j < array.GetLength(1) - 1)) ? ", " : "]");
            }
        }
        return str;
    }

    public static char[,] create_array(int r, int c)
    {
        char[,] array = new char[r, c];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = (char)(rand.Next('a', 'z'));
            }
        }
        return array;
    }

    public static void print_array(char[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}