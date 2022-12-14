// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[,] ArSortMaxMin(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k+1])
            {
                int tmp = matr[i, k];
                matr[i, k] = matr[i, k+1];
                matr[i, k+1] = tmp;
            }
            }
        }
    }
    return matr;
}

int[,] array1 = CreateMatrixRndInt(5, 6, 1, 9);
Console.WriteLine("Массив до сортировки: ");
PrintMatrix(array1);
int [,] array2= ArSortMaxMin(array1);
Console.WriteLine();
Console.WriteLine("Массив после сортировки: ");
PrintMatrix(array2);