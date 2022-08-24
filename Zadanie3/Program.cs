Console.Write("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());
while (a < 1 || a > 8)
{
    Console.WriteLine("Число " + a + " не является номером дня недели");
    Console.Write("Введите номер дня недели: ");
    a = int.Parse(Console.ReadLine());
}
if (a < 6)
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Выходной!");
}
