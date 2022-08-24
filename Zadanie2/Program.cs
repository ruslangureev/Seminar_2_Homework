Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

while (a < 100)
{
    Console.WriteLine("У " + a + " отсутствует третья цифра" );
    Console.Write("Введите корректное число: ");
    a = int.Parse(Console.ReadLine());
}
    Console.WriteLine("У " + a + " третья цифра в числе: " + a.ToString() [2]);
