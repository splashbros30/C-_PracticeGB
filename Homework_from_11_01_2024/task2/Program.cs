// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

int[] arr = new int[10];
Console.Write("Массив : [ ");
Random rand = new();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-100, 100);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine("]");

int count = 0;

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] % 2 == 0)
    {
        count++;
    }
}

Console.Write($"Количество чётных чисел в массиве = {count}");
