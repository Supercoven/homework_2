Console.WriteLine("Введите порядковый номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 5 && a < 8) 
{
Console.WriteLine("Ура, сегодня выходной!");
}
else if (a > 0 && a < 6)
{
Console.WriteLine("Вставай, иди на работу!");    
}
else
{
Console.WriteLine("Хорошая пятница вчера была, да?"); 
}