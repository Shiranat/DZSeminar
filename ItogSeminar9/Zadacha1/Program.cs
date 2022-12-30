// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите N:  ");
int n = Int.Parse(Console.ReadLine());

string PrintNumbers(int Number)
{
    if (Number == 1) return "1";
    return (Number + " " + PrintNumbers(Number - 1));
}
Console.WriteLine(PrintNumbers(n));

// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.Clear();
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine(PrintNumbers(n));

// string PrintNumbers(int number)
// {
//     if (number == 1) return "1";
//     string answer = number + " " + PrintNumbers(number - 1);
//     return answer; // "3  2  1"
// }
