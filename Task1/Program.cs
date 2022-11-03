// void TriNumber()
// {
// int b = a % 100 / 10;
// Console.WriteLine($"вторая цифра в числе: {b}");
// }

// Console.WriteLine("Введите трёхзначное целое число");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = 0;
// TriNumber b;
Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;

void Tri()
{
    if (a >99 & a < 1000)
    {
        Console.WriteLine("Число не трёхначное");
        return;
    }
    else (int b = a % 100 / 10);
    {
Console.WriteLine($"вторая цифра в числе: {b}");
    }

Tri(int a);