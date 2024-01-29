// Задача 2: Задайте двумерный массив. Напишите 
// программу, которая поменяет местами первую и 
// последнюю строку массива.



using System;

class main_prog
{
    static Random rand = new Random();
    static int[,] arr;

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность массива: ");
        Console.WriteLine("Кол-во строк: ");
        int r = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Кол-во столбцов: ");
        int c = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите диапазон цифр для массива: ");
        Console.WriteLine("От: ");
        int f = int.Parse(Console.ReadLine()!);
        Console.WriteLine("До: ");
        int t = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
        arr = CreateMatrix(r, c, f, t);
        show_matrix(arr);
        Console.WriteLine();
        Console.WriteLine(" || ");
        Console.WriteLine();
        show_matrix(reverse_first_and_last_row(arr));
    }

    static int[,] CreateMatrix(int row_count, int colums_count, int from, int to)
    {
        int[,] matrix = new int[row_count, colums_count];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rand.Next(from, to + 1);
            }
        }
        return matrix;
    }

    static void show_matrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static public int[,] reverse_first_and_last_row(int[,] array)
    {
        int[] mas_temp_first = new int[array.GetLength(1)];
        int[] mas_temp_last = new int[array.GetLength(1)];

        for (int j = 0; j < array.GetLength(1); j++)
        {
            mas_temp_first[j] = array[0, j];
            mas_temp_last[j] = array[array.GetLength(0) - 1, j];
        }

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[0, j] = mas_temp_last[j];
            array[array.GetLength(0) - 1, j] = mas_temp_first[j];
        }
    return array;
    }
}