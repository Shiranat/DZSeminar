// Задача 1. По двум заданным числам проверять является ли первое квадратом второго.

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberB * numberB == numberA)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго.");
}