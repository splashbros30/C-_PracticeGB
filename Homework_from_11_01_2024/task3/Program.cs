// Задача 3: Задайте массив из вещественных чисел с 
// ненулевой дробной частью. Найдите разницу между 
// максимальным и минимальным элементов массива. 

using System;
          
Console.WriteLine("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine()!);
double[] arr = new double[N];
Random rand = new();
Console.Write("Массив : [  ");
for(int i = 0; i < arr.Length; i++)
{
  arr[i] = rand.Next(0, 100) + rand.NextDouble();
  arr[i] = Math.Round(arr[i], 2);
  Console.Write($"{arr[i]}  ");
}
Console.WriteLine("]");

double max = arr[0];
double min = arr[0];

for(int j = 0; j < arr.Length; j++)
{
  if (arr[j] < min)
  {
    min = arr[j];
  }
  
  if (arr[j] > max)
  {
    max = arr[j];
  }  
}
Console.WriteLine($"min = {min}");
Console.WriteLine($"max = {max}");

double diff = Math.Round(Math.Abs(max - min), 4);

Console.Write($"Разница между максимальным и минимальным элементом массива равна = {diff}");