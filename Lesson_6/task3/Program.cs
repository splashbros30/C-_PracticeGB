// Задание 3. Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.

string vowels = "aeiou";

Console.WriteLine("Введите строку:");

string str = Console.ReadLine()!;
char[] cats = new char[str.Length];
int c = 0;

for (int i = 0; i < str.Length; i++)
{
    cats[i] = str[i];
}

prog(cats);

int number_of_vowels(char a)
{
    int count = 0;
    if (vowels.Contains(a))
    {
        count++;
    }
    return count;
}

void prog(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (Char.IsLower(array[i]))
        {
            if (number_of_vowels(array[i]) != 0)
            {
                c++;
            }
        }
        else if (Char.IsUpper(array[i]))
        {
            Console.WriteLine("Введена буква верхнего регистра!");
            return;
        }
        else
        {
            Console.WriteLine("Введен символ, не являющийся буквой.");
            return;
        }
    }
    Console.WriteLine("Количество гласных букв в введённой строке:");
    Console.WriteLine($"{str} => {c}");
}

