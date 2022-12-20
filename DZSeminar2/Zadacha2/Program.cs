// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
string numberString = $"{number}";
int lenght = numberString.Length;

if (lenght >= 3 )
{
    Console.Write("Третья цифра числа: ");
    Console.Write(numberString[2]);
}
else
    {
        Console.Write("третьей цифры нет");
    }