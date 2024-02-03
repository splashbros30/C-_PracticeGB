// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.


using System;



class prog
{
    static Random rand = new Random();
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine()!;
        char[] characters = str.ToCharArray();
        Console.WriteLine();
        Console.WriteLine("Строка со словами наоборот:");
        Console.WriteLine(result(characters));
    }

    public static string result(char[] array)
    {
        string temp = "";
        string sp = " ";
        char[] space = sp.ToCharArray();
        string t = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i] == space[0])
            {
                temp = t + " " + temp;
                t = "";
            }
            else
            {
                t = t + array[i];
                if (array[i] == array[array.GetLength(0) - 1])
                {
                    temp = t + " " + temp;
                }
            }
        }
        return temp;
    }


}