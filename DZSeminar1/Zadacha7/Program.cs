// Задача 7. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

int a = new Random().Next(10, 99);
Console.Write("Число: ");
Console.WriteLine(a);

if (a > 10 && a < 99)
{
    if (a / 10 > a % 10)
    {
        Console.WriteLine("Первая цифра числа больше");
    }
    else
    if (a / 10 == a % 10)
    {
        Console.WriteLine("Цифры одинаковы");
    }
    else
        Console.WriteLine("Вторая цифра числа больше");
}