// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]. 

int[] arr  = new int[10];
Random rand = new();
Console.Write("Массив: [ ");
for (int i = 0; i < arr.Length; i++)
{
   arr[i] = rand.Next(1, 100);
   Console.Write($"{arr[i]}   ");
}
Console.WriteLine("]");
Console.WriteLine();

int count = 0;

for (int j = 0; j < arr.Length; j++)
{
    if ((arr[j] >= 20) && (arr[j] <= 90) )
    {
        count++;
    }
}

Console.Write($"Количество чисел в массиве из промежутка [20, 90] = {count}");
