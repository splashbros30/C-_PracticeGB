// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

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
        int a;
        int b;
        int n;
        lowest_number_of_array(arr, out a, out b, out n);
        Console.WriteLine($"Наименьшее число в матрице = {n}");
        Console.WriteLine();
        show_matrix(create_new_matrix(arr, a, b));
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

    static public void lowest_number_of_array(int[,] array, out int a, out int b, out int n)
    {
        n = array[0, 0];
        a = 0;
        b = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < n)
                {
                    n = array[i, j];
                    a = i;
                    b = j;
                }
            }
        }
    }

    static public int[,] create_new_matrix(int[,] matrix, int c, int d)
    {
        int row_to_remove = c; // Номер строки, которую нужно удалить
        int col_to_remove = d; // Номер столбца, который нужно удалить

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[,] new_array = new int[rows - 1, cols - 1];

        int new_row = 0;
        int new_col = 0;

        for (int i = 0; i < rows; i++)
        {
            if (i != row_to_remove)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != col_to_remove)
                    {
                        new_array[new_row, new_col] = matrix[i, j];
                        new_col++;
                    }
                }
                new_row++;
                new_col = 0;
            }
        }
        return new_array;
    }

}