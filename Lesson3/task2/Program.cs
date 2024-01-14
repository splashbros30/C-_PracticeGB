// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

int N = 10;
int[] arr = new int[N];
int i = 0;

Console.WriteLine($"Введите все {N} элементов(-а) массива из промежутка [-10;10]: ");

while (i < arr.Length)
{
    arr[i] = int.Parse(Console.ReadLine()!);
    if ((-10 > arr[i]) || (10 < arr[i]))
    {
        Console.WriteLine("WARNING!!!" + '\n' + "Необходимо вводить числа только из промежутка [-10;10]:");
        break;
    }
    i++;
}

for (int j = 0; j < arr.Length; j++)
{
    arr[j] = arr[j] * (-1);
}

Console.WriteLine($"Массив после замены : ");

for (int e = 0; e < arr.Length; e++)
{
    Console.Write($"{arr[e]} ");
}