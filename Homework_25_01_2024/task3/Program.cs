// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

using System;

class Program
{
    static Random rand = new Random();

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
        int[,] arr = CreateMatrix(r, c, f, t);
        show_matrix(arr);
        Console.WriteLine();
        Console.WriteLine($"Строка с индексом = {number_of_lowest_summ(summs_of_row(arr))}");
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

    static public int[] summs_of_row(int[,] array)
    {
        int[] arr_summ = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arr_summ[i] = arr_summ[i] + array[i, j];
            }
        }
        return arr_summ;
    }

    static public int number_of_lowest_summ(int[] array)
    {
        int low = array[0]; 
        int number = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < low)
            {
                low = array[i];
                number = i;
            }
        }
        return number;
    }
}