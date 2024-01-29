// Задание 1. Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты.

using System;

int[,] CreateMatrix(int row_count, int colums_count, int from, int to)
{
    int[,] matrix = new int[row_count, colums_count];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(from, to);
        }
    }
    return matrix;
}

void show_matrix(int[,] matrix)
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

int[,] solution_array(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i = i + 2)
  {
    for (int j = 0; j < array.GetLength(1); j = j + 2)
    {
      if ((i % 2 == 0) && (j % 2 == 0))
      {
        array[i, j] = (int)Math.Pow(array[i, j], 2);
      }
    }
  }
  return array;
}

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
int[,] arr = CreateMatrix(r, c, f, t);
show_matrix(arr);
Console.WriteLine();
solution_array(arr);
show_matrix(arr);