// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

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
    Console.Write("]");
}

int[] ReverseArray(int[] array)
{
    int[] reverse_array = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reverse_array[i] = array[array.Length - i - 1];
    }
    return reverse_array;
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
Console.Write(" => ");
PrintArray(ReverseArray(arr));