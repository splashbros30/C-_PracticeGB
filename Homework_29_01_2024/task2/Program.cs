// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 

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
        Console.WriteLine("Строка после изменения:");
        Console.WriteLine(char_to_string(is_upper_or_is_lower(characters)));
    }

    public static char[] is_upper_or_is_lower(char[] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (Char.IsUpper(array[i]))
            {
                array[i] = Char.ToLower(array[i]);
            }
        }
        return array;
    }

    public static string char_to_string(char[] array)
    {
        string temp = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            temp = temp + array[i];
        }
        return temp;
    }
}