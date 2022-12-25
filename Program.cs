/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/



int[,] arr =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 1, 1 },
    { 5, 2, 6, 7 }
};

int minSumRow = 0;
int sumRow = SumElementsOfRow(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
    int tempSumRow = SumElementsOfRow(arr, i);
    if (sumRow > tempSumRow)
    {
        sumRow = tempSumRow;
        minSumRow = i;
    }
}

int SumElementsOfRow(int[,] arr, int i)
{
    int sumRow = arr[i, 0];
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        sumRow += arr[i, j];
    }
    return sumRow;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine($"{minSumRow + 1} - строка с наименьшей суммой элементов");