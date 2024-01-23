// Задача 1: Напишите программу, которая бесконечно запрашивает целые 
// числа с консоли. Программа завершается при вводе символа ‘q’ или 
// при вводе числа, сумма цифр которого чётная.

int SummNumbers(int num)
{
    int b = 0;
    int count = 0;
    while (num != 0)
    {
        b = b + (num % 10);
        num = num / 10;
    }

    Console.WriteLine(b);

    if (b % 2 == 0)
    {
        count = 1;
    }
    else
    {
        count = 0;
    }
    return count;
}

int StopMethod(int c)
{
    int ans = 0;
    if (c == 1)
    {
        ans = 1;
    }
    return ans;
}

for (; ; )
{
    Console.WriteLine("Введите целое число или завершающую 'q' : ");
    string a = Console.ReadLine()!;

    int x;

    if (int.TryParse(a, out x))
    {
        if (StopMethod(SummNumbers(x)) == 1)
        {
            break;
        }
    }
    else if (a == "q")
    {
            break;
    }

    continue;
}
