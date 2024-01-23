// Задание 2. Задайте массив из N случайных целых чисел 
// (N вводится с клавиатуры). Найдите количество чисел, 
// которые оканчиваются на 1 и делятся нацело на 7.

// Пример
// [1 5 11 21 81 4 0 91 2 3] => 2

// ОПТИМИЗАЦИЯ - финальный массив, выведенный после "=>", 
// включает в себя сами числа массива, удовлетворяющие условию, 
// а на 0-вом индексе располагается количество данных чисел.

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

int[] answer_array(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 10 == 1) && (array[i] % 7 == 0))
        {
            count++;
        }
    }

    int[] ans_arr = new int[count + 1];
    ans_arr[0] = count;
    int x = 1;

    for (int j = 0; j < array.Length; j++)
    {
        if ((array[j] % 10 == 1) && (array[j] % 7 == 0))
        {
            ans_arr[x] = array[j];
            x++;
        }
    }
    return ans_arr;
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
PrintArray(answer_array(arr));
