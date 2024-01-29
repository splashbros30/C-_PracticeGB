// Задание 3. Задайте двумерный массив из целых чисел. Сформируйте новый 
// одномерный массив, состоящий из средних арифметических 
// значений по строкам двумерного массива.


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

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
    if (i < array.Length - 1)
    {
      Console.Write($"{array[i]}   ");
    }
        else
    {
      Console.Write($"{array[i]} ");
    }
    }
    Console.Write("]");
}

double[] solution_array(int[,] array)
{
  double[] arr = new double[array.GetLength(0)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        arr[i] = arr[i] + array[i, j];
    }
    arr[i] = Math.Round(arr[i] / array.GetLength(1), 2);
  }
  return arr;
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
Console.WriteLine();
int[,] arr = CreateMatrix(r, c, f, t);
show_matrix(arr);
Console.WriteLine();
Console.WriteLine("Новый массив из среднеарифметических чисел строк: ");
PrintArray(solution_array(arr));