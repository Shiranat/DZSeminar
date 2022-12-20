// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int x = 1;

while (x <= N)
{
    Console.WriteLine(Math.Pow(x, 3));
    x++;
}
Console.Write("Таблица готова");
