﻿// Задача 5. Показать последнюю цифру трёхзначного числа.

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a % 10;
Console.Write("Последняя цифра числа: ");
Console.WriteLine(b);
