Console.Write("Enter you number : ");
int a = int.Parse(Console.ReadLine()!);
int i = -a;

if (a >= 0)
{
while (i <= a)
{
    Console.Write(i + " ");
    i = i + 1;
}
}
else 
{
    while (i >= a)
    {
        Console.Write(i + " ");
        i = i - 1;
    }
}