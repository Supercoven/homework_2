Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());

int b = a % 100 / 10;
Console.WriteLine(b);