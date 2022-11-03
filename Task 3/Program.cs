void Day(int daynumber)
{
    if (daynumber > 0 & daynumber < 6) Console.WriteLine("Сегодня рабочий день");
    else if (daynumber > 5 & daynumber < 8) Console.WriteLine("Сегодня выходной");
    else Console.WriteLine("Вы ввели неверный день недели");
}

Console.WriteLine("Введите номер дня недели");
int daynumber = Convert.ToInt32(Console.ReadLine());
Day(daynumber);