/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int temp = 1;
int i = 0;
int j = 0;


void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (mtrx[i, j] / 10 <= 0 )
            {
                Console.Write($" {mtrx[i, j]} ");
            }
            else
            {
                Console.Write($"{mtrx[i, j]} ");
            } 
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] GenerateRandomMatrix(int min, int max, int m, int n)
{
    int[,] mtrx = new int[m, n];
    Random r = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mtrx[i, j] = r.Next(min, max + 1);
        }
    }
    return mtrx;
}


int[,] matrix = GenerateRandomMatrix(0, 20, 4, 4);
PrintMatrix(matrix);

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
    matrix[i,j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    {
        j++;
    }
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
    {
        i++;
    }
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
}

PrintMatrix(matrix);