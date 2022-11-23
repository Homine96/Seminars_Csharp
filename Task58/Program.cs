// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultiplMatrix(int[,] arr, int[,] matr)
{
    int[,] matrix = new int[arr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                matrix[i, j] = matrix[i, j] + arr[i, k] * matr[k, j];
            }
        }
    }
    return matrix;
}


Console.Write("Введите количество строк матрицы №1: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы №1: n=");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк матрицы №2 : c=");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы №2: d=");
int d = Convert.ToInt32(Console.ReadLine());

int[,] arr1 = CreateMatrixRndInt(m, n, 0, 9);
int[,] arr2 = CreateMatrixRndInt(c, d, 0, 9);

if (n == c)
{
    int[,] newMatrix = MultiplMatrix(arr1, arr2);

    Console.WriteLine("Матрица №1: ");
    PrintMatrix(arr1);
    Console.WriteLine();
    Console.WriteLine("Матрица №2: ");
    PrintMatrix(arr2);
    Console.WriteLine();
    Console.WriteLine("Результирующая матрица: ");
    PrintMatrix(newMatrix);
}
else Console.Write("Перемножение матриц невозможно");