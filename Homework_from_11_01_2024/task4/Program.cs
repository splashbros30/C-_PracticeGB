// Задача 4**(не обязательно): Дано натуральное 
// число в диапазоне от 1 до 100 000. Создайте массив, 
// состоящий из цифр этого числа. Старший разряд 
// числа должен располагаться на 0-м индексе 
// массива, младший – на последнем. Размер массива 
// должен быть равен количеству цифр.


using System;

Random rand = new();
int A = rand.Next(1, 100000);
Console.WriteLine($"Число из диапазона = {A}");

int N = 1;

int B = A;

while (B / 10 != 0)
{
  B /= 10;
  N++;
}
// Console.WriteLine($"N = {N}");
int[] arr = new int[N];

for(int i = N-1; i >= 0; i--)
{
  arr[i] = A % 10;
  A = A / 10;
//  Console.WriteLine($"arr[{i}] = {arr[i]}; A = {A}");
}

Console.Write($"Массив из цифр числа : [ ");

for(int j = 0; j < arr.Length; j++)
{
  Console.Write($"{arr[j]} ");
}
Console.Write("]");