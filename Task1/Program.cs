Console.WriteLine("Введите трёхзначное целое число");
int a = Convert.ToInt32(Console.ReadLine());

int b = a % 100 / 10;
Console.WriteLine($"вторая цифра в числе: {b}");