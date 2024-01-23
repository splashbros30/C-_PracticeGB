// Задание 3. Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.

// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 10);
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

double result(int[] array, int n)
{
    double number = 0;
    switch (n)
    {
        case 1:
            number = array[0];
            break;
        case 2:
            number = (array[0] * 10) + array[1];
            break;
        case 3:
            number = (array[0] * 100) + (array[1] * 10) + array[2];
            break;
        case 4:
            number = (array[0] * 1000) + (array[1] * 100) + (array[2] * 10) + array[3];
            break;
        case 5:
            number = (array[0] * 10000) + (array[1] * 1000) + (array[2] * 100) + (array[3] * 10) + array[4];
            break;
        case 6:
            number = (array[0] * 100000) + (array[1] * 10000) + (array[2] * 1000) + (array[3] * 100) + (array[4] * 10) + array[5];
            break;
        case 7:
            number = (array[0] * 1000000) + (array[1] * 100000) + (array[2] * 10000) + (array[3] * 1000) + (array[4] * 100) + (array[5] * 10) + array[6];
            break;
        case 8:
            number = (array[0] * 10000000) + (array[1] * 1000000) + (array[2] * 100000) + (array[3] * 10000) + (array[4] * 1000) + (array[5] * 100) + (array[6] * 10) + array[7];
            break;
    }
    return number;
}

Console.WriteLine("Введите количество элементов массива(от 1 до 8): ");
int N = int.Parse(Console.ReadLine()!);
if ((N > 1) && (N < 9))
{
    int[] arr = CreateArray(N);
    PrintArray(arr);
    Console.Write(" => ");
    Console.Write(result(arr, N));
}
else
{
    Console.Write("Вы ввели число не из промежутка!!!");
}
