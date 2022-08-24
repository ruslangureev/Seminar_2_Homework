Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

while (a < 100 || a > 1000)
{
    Console.WriteLine("Введите число в диапазоне от 100 до 999");
    a = int.Parse(Console.ReadLine());
}

int a1 = a % 10;
int res = (a - a1) % 100 / 10;
Console.WriteLine("У числа " + a + " вторая цифра: " + res);