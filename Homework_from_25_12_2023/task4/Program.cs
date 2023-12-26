// Задача 4: Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("\n");

Console.Write("Введите число для разбивки = ");
int a = int.Parse(Console.ReadLine()!);
int b = 1;
string s = "";

Console.Write("\n");

while (((a / 10) >= 0) && ((a % 10) != 0))
{
    b = a % 10;
    s = s + b + ' ' + ',';
    a = a / 10;
}

string del = s.TrimEnd(' ', ',');


char[] charArray = del.ToCharArray();
Array.Reverse(charArray);

string answer = new string(charArray);

Console.Write("answer = " + answer);