// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. (читается слева направо и справа налево одинаково).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
string numberString = $"{number}";
int lenght = numberString.Length;

while (lenght <= 5)
{
    if (numberString[0] == numberString[4] && numberString[1] == numberString[3])
    {
        Console.Write("Число палиндром.");
    }
    else
    {
        Console.Write("Число не палиндром.");
    }
    lenght++;
}
