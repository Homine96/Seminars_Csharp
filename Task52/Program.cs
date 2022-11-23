// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] SrArifmet(int [,] matr)
{
    double[] arr=new double [4];
    
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
             
             sum = sum + matr[i,j];
             double mid=sum / matr.GetLength(0);
             arr[j] = mid ;
        }
        
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write(" ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(Math.Round(arr[i],1));
        if (i < arr.Length - 1) Console.Write(" | ");
    }
    Console.WriteLine(" ");
}

int [,] array=CreateMatrixRndInt(3,4,1,9);
Console.WriteLine("Задан двумерный массив 3х4 ");
PrintMatrix(array);
double [] array2=SrArifmet(array);
Console.Write("Среднее арифметическое каждого столбца в массиве равно : ");
PrintArray(array2);