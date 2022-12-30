// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите N:  ");
int n = Int.Parse(Console.ReadLine());

string PrintSum(int Number)
{
    if (Number == 1) return "1";
    return (Number + PrintSum(Number - 1));
}
Console.Write(PrintNumbers(n));

// Задача 2: Задайте значение N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от 1 до N.
// M = 1; N = 15 -> 120

// Console.Clear();
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine(SumNumbers(1, n));

// int SumNumbers(int start, int end)
// {
//     if (start == end) return end;
//     int answer = start + SumNumbers(start + 1, end);
//     return answer;
// }
