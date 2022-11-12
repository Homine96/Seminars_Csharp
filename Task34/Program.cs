﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}  

int EvenNumb(int [] arr)
{
    int sum=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) sum +=1;
    }
    return sum;
}

int [] massiv = CreateArrayRndInt(4,100,999);
PrintArray(massiv);
int sum=EvenNumb(massiv);

Console.Write($"Количество четных чисел в массиве = {sum}");