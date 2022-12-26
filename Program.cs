/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void PrintIndex(int[,,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            System.Console.WriteLine();
            for (int g = 0; g < mtrx.GetLength(2); g++)
            {
                System.Console.Write($"{mtrx[i, j, g]}({i},{j},{g})");
            }
        }
    }
}
int[,,] GenerateRandomMatrix(int min, int max, int m, int n, int k)
{
    int[,,] mtrx = new int[m, n, k];
    Random r = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int g = 0; g < k; g++)
            {
                mtrx[i, j, g] = r.Next(min, max + 1);
            }
        }
    }
    return mtrx;
}


int[,,] randMatrix = GenerateRandomMatrix(0, 9, 2, 2, 2);
PrintIndex(randMatrix);