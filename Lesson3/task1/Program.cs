// Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве. Программа
//должна выдать ответ: Да/Нет.

Console.WriteLine($"Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine()!);

int[] arr = new int[N];
int i = 0;

Console.WriteLine($"Введите все {N} элементов(-а) массива: ");

while (i < arr.Length)
{
    arr[i] = int.Parse(Console.ReadLine()!);
    i++;
}

Console.WriteLine($"Введите число, которое нужно поискать в массиве: ");
int a = int.Parse(Console.ReadLine()!);
int count = 0;

//Console.WriteLine($"Да");

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] == a)
    {
        count++;
    }
}

if (count > 0)
{
    Console.WriteLine($"Да");
}
else
{
    Console.WriteLine($"Нет");
}