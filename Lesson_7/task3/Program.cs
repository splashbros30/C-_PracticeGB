// Задание 3. Считать строку с консоли, содержащую 
// латинские буквы. Вывести на экран согласные 
// буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.

using System;

class Prog()
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine()!;
        // "B, C, D, F, G, H, J, K, L, M, N, P, Q, R, S, T, V, W, X, Z"
        string consonants = new string("bcdfghjklmnpqrstvwxz");
        Console.WriteLine();
        Console.WriteLine("Consonants in entered string: ");
        consonants_letters(str, consonants);
    }

    public static void consonants_letters(string st, string cons, int index = 0)
    {
        if (st.Length == index)
        {
            return;
        }

        if (cons.Contains(char.ToLower(st[index])))
        {
            Console.Write($"{st[index]} ");
        }

        consonants_letters(st, cons, index + 1);
    }

}