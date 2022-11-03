void Tri(int a)
{
int b = a % 100 / 10;
Console.WriteLine($"вторая цифра в числе: {b}");
}

Console.WriteLine("Введите трёхзначное целое число");
int a = Convert.ToInt32(Console.ReadLine());
Tri(a);