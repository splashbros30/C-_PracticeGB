// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

Console.WriteLine($"Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine()!);

int[] arr = new int[N];
int N_F = N / 2;
int[] arrAns = new int[N_F];
int i = 0;

Console.WriteLine($"Введите все {N} элементов(-а) массива: ");

while (i < arr.Length)
{
    arr[i] = int.Parse(Console.ReadLine()!);
    i++;
}

for (int j = 0; j < N_F; j++)
{
    arrAns[j] = arr[j] * arr[N - 1 - j];
}

for (int e = 0; e < N_F; e++)
{
    Console.WriteLine($"Элемент {e} нового массива равен: {arrAns[e]}");
}

if (N % 2 != 0)
{
    Console.WriteLine($"(Элемент введённого массива {arr[N_F]} с индексом {N_F} не имеет пары)");
}
