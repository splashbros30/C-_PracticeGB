// 4. Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число = ");
int a = int.Parse(Console.ReadLine()!);

if (a >=100)
{
    int num = a / 100 % 10;
    Console.WriteLine(num);
}
else
{
    if (a < 100)
    {
        Console.WriteLine("Неверно введённое число");
    }
}