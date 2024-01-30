// Задание 2. На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание:
// Метод строки ToCharArray() не использовать.

string str = "cat";
char[] cats = new char[str.Length];

for (int i = 0; i < str.Length; i++)
{
    cats[i] = str[i];
}

for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine($"cats[{i}] = {cats[i]}");
}



