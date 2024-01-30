// Задание 1. Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание:
// Конструктор строки вида string(char []) не использовать.

char[] array_of_characters = new char[]{'c', 'a', 't'};
string str = "";

for (int i = 0; i < array_of_characters.Length; i++)
{
    str = str + $"{array_of_characters[i]}";
}

Console.WriteLine($"str = {str}");