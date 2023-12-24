Console.Write("Enter a number a = ");
int a1_int = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Enter a number b = ");
int a2_int = Convert.ToInt32(Console.ReadLine()!);


if (a2_int == a1_int*a1_int)
{
    Console.Write("b - квадрат числа a");
}
else{
    Console.Write("b - не является квадратом числа a");
}
