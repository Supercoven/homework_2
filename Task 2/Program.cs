﻿Console.WriteLine("Введите трёхзначное целое число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 100 / 10;
if (a > 99 && a < 999)

Console.WriteLine($"вторая цифра в числе: {b}");
}
else
{
Console.WriteLine("Вы ввели неверное число");    
}