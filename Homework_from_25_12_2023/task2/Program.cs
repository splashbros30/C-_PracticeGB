// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

Console.Write("\n");

Console.WriteLine("Для работы программы дробные значения необходимо вводить через ','");

Console.Write("\n");

Console.Write("Введите координаты точки по оси X = ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("\n");
Console.Write("Введите координаты точки по оси Y = ");
double y = Convert.ToDouble(Console.ReadLine());

Console.Write("\n");

if ((x == 0) || (y == 0))
{
    Console.WriteLine("Точка не лежит ни в какой координатной четверти!");
}

if ((x > 0) && (y > 0))
{
    Console.WriteLine("Точка лежит в '1' координатной четверти!");
}

if ((x > 0) && (y < 0))
{
    Console.WriteLine("Точка лежит в '4' координатной четверти!");
}

if ((x < 0) && (y > 0))
{
    Console.WriteLine("Точка лежит во '2' координатной четверти!");
}

if ((x < 0) && (y < 0))
{
    Console.WriteLine("Точка лежит в '3' координатной четверти!");
}

//Console.WriteLine("Координаты точки по оси X = " + x);
//Console.WriteLine("Координаты точки по оси Y = " + y);
