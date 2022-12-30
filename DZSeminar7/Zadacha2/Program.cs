// Задача 50. Напишите программу, которая на вход принимает число, 
// и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillNewArr(int[,] NewArr)
{
    for (int i = 0; i < NewArr.GetLength(0); i++)
    {
        for (int j = 0; j < NewArr.GetLength(1); j++)
        {
            NewArr[i, j] = new Random().Next(1, 10);
        }
    }
    return NewArr;
}
void PrintNewArr(int[,] NewArr)
{
    for (int i = 0; i < NewArr.GetLength(0); i++)
    {
        for (int j = 0; j < NewArr.GetLength(1); j++)
        {
            Console.Write(NewArr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] NewArr = new int[3, 4];
NewArr = FillNewArr(NewArr);
PrintNewArr(NewArr);

Console.Write("Введите число -> ");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < NewArr.GetLength(0); i++)
{
    for (int j = 0; j < NewArr.GetLength(1); j++)
    {
        if (NewArr[i, j] == number && number < 10)
        {
            Console.WriteLine($"[{Convert.ToInt32(i)},{Convert.ToInt32(j)}]");
        }
        else
        {
            Console.WriteLine(number + "-> такого числа в массиве нет.");
            break;
        }
    }
}