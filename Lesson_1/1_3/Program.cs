Console.Write("Enter you number : ");
int a = int.Parse(Console.ReadLine()!);
int b = a%10;
int c = a / 100;
int d = b + c;
if (a > 0)
{
Console.WriteLine("Summ of first and third numbers of entered number = " + d);
}
else{
    Console.WriteLine("Summ of first and third numbers of entered number = " + (-d));
}