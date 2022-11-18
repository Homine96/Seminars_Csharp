// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

Console.WriteLine("Введите номер строки и солбца, чтобы узнать значение элемента массива 3х4");
Console.Write("Номер  строки = ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер  столбца = ");
int j = Convert.ToInt32(Console.ReadLine());

int [,] array=CreateMatrixRndInt(3,4,1,9);
PrintMatrix(array);
if ( i -1 < 0 || i - 1 > 2 
    && j-1  <0 || j-1 > 3) Console.Write($"{i},{j} - такого элемента нет");
else Console.WriteLine ($"Элемент  {i} строки, {j} столбца в массиве равен {array[i-1,j-1]} ");