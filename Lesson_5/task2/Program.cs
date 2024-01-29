// Задание 2. Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и 
// т.д.)


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
      if (i == j)
      {
        Console.Write($"*{matrix[i, j]}* ");
      }
      else
      {      
              Console.Write($"{matrix[i, j]} ");
      }
        }
        Console.WriteLine();
    }
}

void summ_of_main_diag(int[,] array, out int summ, out string diagonalElements)
{
  summ = 0;
  diagonalElements = "(";
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j)
      {
        if ((i < array.GetLength(0) - 1) && (j < array.GetLength(1) - 1))
        {
          diagonalElements += array[i, i] + " + ";
        }
        else
        {
          diagonalElements += array[i, i] + ")";
        }
        summ = summ + array[i, j];
      }
    }
  }
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
int summ;
string diagonalElements;
summ_of_main_diag(arr, out summ, out diagonalElements);
Console.WriteLine($"Сумма элементов главной диагонали: \n{diagonalElements} = {summ}");