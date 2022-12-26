// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
string numberString = $"{number}";
int lenght = numberString.Length;
int Sum = 0;

for (int i = 0; i < lenght; i++)
{
    string a = $"{numberString[i]}";
    Sum = Sum + Convert.ToInt32(a);
}
string str = $"Сумма цифр в числе {number} = {Sum}";
Console.WriteLine(str);
