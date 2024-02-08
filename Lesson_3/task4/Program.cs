// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 

Console.WriteLine("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int[] arr = new int[3];

if ((a > 99) && (a < 1000))
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        int b = a % 10;
        arr[i] = b;
        a = a / 10;
        Console.Write($"{b} ");
    }
    Console.Write("]");
}
else
{
    Console.Write("Вы ввели не трёхзначное число!!!");
}

