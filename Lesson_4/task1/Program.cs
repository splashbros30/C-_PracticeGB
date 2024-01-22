//Задание 1. Совместная работа
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом              Простые числа до 100: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 
// массиве.                                                                               41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83,
// Примеры                                                                                89, 97.
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

int[] CreateArray(int from, int to, int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

int TestingForPrime(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (FindPrimeNumber(array[i]))
            count++;
    }
    return count;
}

bool FindPrimeNumber(int num)
{
    if (num < 2)
        return false;
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}
Console.WriteLine("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите границы массива: ");
Console.Write("От - ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("До - ");
int b = int.Parse(Console.ReadLine()!);
int[] arr = CreateArray(a, b, N);
PrintArray(arr);
int answer = TestingForPrime(arr);
Console.Write($"Количество простых чисел в массиве = {answer}");

