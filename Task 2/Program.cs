Console.WriteLine("Введите трёхзначное целое число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 100 / 10;
if (a > 99 && a < 999) // решил сделать просто без конверсии и парсинга строки пока
{
Console.WriteLine($"вторая цифра в числе: {b}");
}
else
{
Console.WriteLine("Вы ввели неверное число");    
}