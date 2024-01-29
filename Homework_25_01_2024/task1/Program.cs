// Задача 1: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.


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
        Console.WriteLine("Введите позицию элемента: ");
        Console.WriteLine("Строка: ");
        int str = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Столбец: ");
        int sto = int.Parse(Console.ReadLine()!);
        Console.WriteLine();

        if (if_not_in_matrix(arr, str, sto))
        {
            int el = arr[str, sto];
            Console.WriteLine($"Значение элемента матрицы: {el}");
        }
        else
        {
            Console.Write("Элемента с таким номером нет в матрице!");
        }
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

    static public bool if_not_in_matrix(int[,] array, int str, int sto)
    {
        if ((str < 0) || (str > array.GetLength(0)) || ((sto < 0) || (sto > array.GetLength(1))))
        {
            return false;
        }
        else
            return true;
    }
}