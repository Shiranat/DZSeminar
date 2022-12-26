// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
int result = 1;

for (int i = 1; i <= B; i++)
{
    result = result * A;
}
string str = $"Число {A} в степени {B} = {result}";
Console.WriteLine(str);
